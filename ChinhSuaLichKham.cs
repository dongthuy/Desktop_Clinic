using System;
using System.Linq;
using System.Windows.Forms;

namespace Clinix
{
    public partial class ChinhSuaLichKham : Form

    {
        private string khungGio;
        private string maLichHen;
        private string gocTrangThai;  
        private DateTime gocNgayHen; 
        private TimeSpan gocKhungGio;
        public ChinhSuaLichKham(string maLichHen, string tenBenhNhan, string sdt, DateTime ngayHen, string khungGio, string trangThai)
        {
            InitializeComponent();
            this.khungGio = khungGio;
            this.maLichHen = maLichHen;

            gocNgayHen = ngayHen;
            gocTrangThai = trangThai;
            gocKhungGio = TimeSpan.Parse(khungGio);

            lblMaLichHen.Text = maLichHen;
            lblTenBenhNhan.Text = tenBenhNhan;
            lblSDT.Text = sdt;

            dtpEditNgayKham.Value = ngayHen;
            dtpEditKhungGio.Value = DateTime.Today.Add(gocKhungGio);

            LoadStatusOptions();
            cbTrangThai.SelectedItem = trangThai;

            dtpEditNgayKham.ValueChanged += RangBuocThoiGian;
            dtpEditKhungGio.ValueChanged += RangBuocThoiGian;
        }
        private void LoadStatusOptions()
        {
            cbTrangThai.Items.Clear();
            cbTrangThai.Items.AddRange(new string[] { "Đã hoàn thành", "Đã hoàn thành, tái khám", "Bị hủy", "Đang chờ" });
        }

        private void frmChinhSuaLichKham_Load(object sender, EventArgs e)
        {
            TimeSpan timeSpan;

            if (!string.IsNullOrEmpty(khungGio) && TimeSpan.TryParse(khungGio, out timeSpan))
            {
                dtpEditKhungGio.Format = DateTimePickerFormat.Time;
                dtpEditKhungGio.ShowUpDown = true;
                dtpEditKhungGio.Value = DateTime.Today.Add(timeSpan);
            }
            else
            {
                dtpEditKhungGio.Value = DateTime.Today.AddHours(8);
                CustomMessageBox.Show("Định dạng thời gian không hợp lệ, mặc định 08:00 AM",
                                "Thông báo",  MessageBoxIcon.Warning);
            }

            dtpEditNgayKham.MinDate = DateTime.Today; 
            dtpEditKhungGio.MinDate = DateTime.Today;

            dtpEditNgayKham.ValueChanged += RangBuocThoiGian;
            dtpEditKhungGio.ValueChanged += RangBuocThoiGian;

        }

       

        private void btnLuu_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = dtpEditNgayKham.Value.Date;
            TimeSpan selectedTime = dtpEditKhungGio.Value.TimeOfDay;
            DateTime combinedDateTime = selectedDate.Add(selectedTime);

            string selectedStatus = cbTrangThai.SelectedItem?.ToString();

            using (var db = new DataClasses2DataContext())
            {
                var appointment = db.LichHens.SingleOrDefault(lh => lh.MaLichHen == maLichHen);

                if (appointment != null)
                {
                    bool isTimeChanged = appointment.NgayHen != selectedDate || appointment.KhungGio != selectedTime;

                    if (isTimeChanged)
                    {
                        if (selectedDate < DateTime.Today ||
                            (selectedDate == DateTime.Today && combinedDateTime < DateTime.Now))
                        {
                            CustomMessageBox.Show("Không thể chỉnh sửa thời gian trong quá khứ.",
                                            "Lỗi",  MessageBoxIcon.Warning);
                            return;
                        }

                        appointment.NgayHen = selectedDate;
                        appointment.KhungGio = selectedTime;
                    }

                    if (appointment.NgayHen < DateTime.Today)
                    {
                        CustomMessageBox.Show("Không thể cập nhật trạng thái cho lịch hẹn đã qua.",
                                        "Lỗi",  MessageBoxIcon.Warning);
                        return;
                    }

                   if (!RangBuocTrangThai(selectedDate, combinedDateTime))
                    {
                        return; 
                    }

                    appointment.TrangThai = selectedStatus;

                    db.SubmitChanges();


                    CustomMessageBox.Show("Cập nhật thành công!", "Thành công",  MessageBoxIcon.Information);

                    DialogResult result = MessageBox.Show("Bạn có muốn tiếp tục chỉnh sửa không?",
                                         "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.No)
                    {
                        this.Close();
                    }
                }
                else
                {
                    CustomMessageBox.Show("Không tìm thấy lịch hẹn cần cập nhật.", "Lỗi",  MessageBoxIcon.Error);
                }
            }
        }
        private void RangBuocThoiGian(object sender, EventArgs e)
        {
            DateTime selectedDate = dtpEditNgayKham.Value.Date;
            DateTime selectedTime = dtpEditKhungGio.Value;

            DateTime combinedDateTime = selectedDate.Add(selectedTime.TimeOfDay);

            if (combinedDateTime < DateTime.Now)
            {
                errorProvider1.SetError(dtpEditKhungGio, "Thời gian không hợp lệ. Chọn thời gian trong tương lai.");
            }
            else
            {
                errorProvider1.SetError(dtpEditKhungGio, "");
            }
        }
        private bool RangBuocTrangThai(DateTime selectedDate, DateTime combinedDateTime)
        {
            string selectedStatus = cbTrangThai.SelectedItem?.ToString();

            using (var db = new DataClasses2DataContext())
            {
                if (selectedStatus == "Đang chờ" && combinedDateTime <= DateTime.Now)
                {
                    CustomMessageBox.Show("Trạng thái 'Đang chờ' chỉ áp dụng cho lịch hẹn trong tương lai.",
                                    "Lỗi", MessageBoxIcon.Warning);
                    return false;
                }

                if ((selectedStatus == "Đã hoàn thành" || selectedStatus == "Đã hoàn thành, tái khám")
                    && combinedDateTime > DateTime.Now)
                {
                    CustomMessageBox.Show("Không thể đặt trạng thái 'Hoàn thành' cho lịch hẹn trong tương lai.",
                                    "Lỗi",  MessageBoxIcon.Warning);
                    return false;
                }

                if (selectedStatus == "Đã hoàn thành, tái khám" &&
                    !db.LichHens.Any(lh => lh.MaBenhNhan == lblMaLichHen.Text && lh.TrangThai == "Đã hoàn thành"))
                {
                    CustomMessageBox.Show("Bệnh nhân này chưa có lịch hẹn hoàn thành để đặt trạng thái 'Tái khám'.",
                                    "Lỗi",  MessageBoxIcon.Warning);
                    return false;
                }
            }

            return true;
        }
        private void btnHuyThayDoi_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Vui lòng xác nhận hủy các thay đổi không?",
                                                 "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                dtpEditNgayKham.Value = gocNgayHen;
                dtpEditKhungGio.Value = DateTime.Today.Add(gocKhungGio);
                cbTrangThai.SelectedItem = gocTrangThai;
                CustomMessageBox.Show("Đã hủy các thay đổi", "Thông báo",  MessageBoxIcon.Information);
                this.Close(); 
            }
        }
    }

}
