using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Drawing.Printing;


namespace Clinix
{
    public partial class ThemLichKham : Form
    {
        public ThemLichKham()
        {
            InitializeComponent();
        }

        private DataClasses2DataContext db = new DataClasses2DataContext();

        private string selectedBNId; 
        private string AutoIncrePKLH()
        {            var lastId = db.LichHens
                           .OrderByDescending(lh => lh.MaLichHen) 
                           .Select(lh => lh.MaLichHen)           
                           .FirstOrDefault();                   
                    
            string numericPart = lastId.Substring(2); 
            int nextIDLH = int.Parse(numericPart) + 1; 
            return $"LH{nextIDLH:D3}"; 
        }


        private void frmThemLichKham_Load(object sender, EventArgs e)
        {         
            LoadBenhNhanData();

            dtpNgayHen.Format = DateTimePickerFormat.Custom;
            dtpNgayHen.CustomFormat = "yyyy-MM-dd"; 
            dtpNgayHen.ShowUpDown = false; 
            dtpKhungGio.Format = DateTimePickerFormat.Custom;
            dtpKhungGio.CustomFormat = "HH:mm";
            dtpKhungGio.ShowUpDown = true;

            LoadBenhNhanData();
    
        }
        private void LoadBenhNhanData()
        {
            var benhNhanData = from bn in db.BenhNhans
                               select new
                               {
                                   MaBenhNhan = bn.MaBenhNhan,
                                   TenBenhNhan = bn.TenBenhNhan,
                                   SDT = bn.SDT,
                                   DiaChi = bn.DiaChi,
                                   GioiTinh = bn.GioiTinh
                               };

            dgvBenhNhan.DataSource = benhNhanData.ToList();
            CustomizeDgvBenhNhan();
        }



        private void dgvBenhNhan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvBenhNhan.Rows[e.RowIndex].Cells.Count > 0)
            {
                DataGridViewRow row = dgvBenhNhan.Rows[e.RowIndex];

                txtMaBenhNhan.Text = row.Cells[0]?.Value?.ToString() ?? string.Empty;
                txtTenBenhNhan.Text = row.Cells[1]?.Value?.ToString() ?? string.Empty;
                txtSDT.Text = row.Cells[2]?.Value?.ToString() ?? string.Empty;
                lblDiaChi.Text = row.Cells[3]?.Value?.ToString() ?? string.Empty;
                lblGioiTinh.Text = row.Cells[4]?.Value?.ToString() ?? string.Empty;
                selectedBNId = row.Cells[0]?.Value?.ToString();
            }
        }

        private void txtTenBenhNhan_TextChanged(object sender, EventArgs e)
        {
            ThucHienTimKiem();

        }
        private void txtSDT_TextChanged(object sender, EventArgs e)
        {
            ThucHienTimKiem();
        }

        private void ThucHienTimKiem()
        {
            string tenBenhNhan = txtTenBenhNhan.Text.Trim();
            string sdt = txtSDT.Text.Trim();

            var query = db.BenhNhans.AsQueryable();

            if (!string.IsNullOrEmpty(tenBenhNhan) && string.IsNullOrEmpty(sdt))
            {
                query = query.Where(bn => bn.TenBenhNhan.Contains(tenBenhNhan));
            }
            else if (!string.IsNullOrEmpty(sdt) && string.IsNullOrEmpty(tenBenhNhan))
            {
                query = query.Where(bn => bn.SDT.Contains(sdt));
            }
            else if (!string.IsNullOrEmpty(tenBenhNhan) && !string.IsNullOrEmpty(sdt))
            {
                query = query.Where(bn => bn.TenBenhNhan.Contains(tenBenhNhan) && bn.SDT.Contains(sdt));
            }
            dgvBenhNhan.DataSource = query.Select(bn => new
            {
                MaBenhNhan = bn.MaBenhNhan,
                TenBenhNhan = bn.TenBenhNhan,
                SDT = bn.SDT,
                DiaChi = bn.DiaChi,
                GioiTinh = bn.GioiTinh
            }).ToList();

            dgvBenhNhan.Refresh();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedBNId))
            {
                CustomMessageBox.Show("Không đủ thông tin bệnh nhân để lưu.",
                                "Chưa chọn bệnh nhân", MessageBoxIcon.Warning);
                return;
            }

            DateTime ngayHen = dtpNgayHen.Value.Date;
            TimeSpan khungGio = dtpKhungGio.Value.TimeOfDay;
            DateTime combinedDateTime = ngayHen.Add(khungGio);

            if (combinedDateTime <= DateTime.Now)
            {
                CustomMessageBox.Show("Thời gian cuộc hẹn phải ở tương lai.",
                                "Thời gian không hợp lệ", MessageBoxIcon.Warning);
                return;
            }

            using (var db = new DataClasses2DataContext())
            {
                var trungLich = db.LichHens.Any(lh =>
                    lh.MaBenhNhan == selectedBNId &&
                    lh.NgayHen == ngayHen &&
                    lh.KhungGio == khungGio);

                

                if (trungLich)
                {
                    CustomMessageBox.Show("Bệnh nhân đã có lịch khám trùng ngày và giờ này.",
                                    "Trùng lịch", MessageBoxIcon.Warning);
                    return;
                }

                string newId = AutoIncrePKLH();
                var newLichHen = new LichHen
                {
                    MaLichHen = newId,
                    MaBenhNhan = selectedBNId,
                    NgayHen = ngayHen,
                    KhungGio = khungGio,
                    TrangThai = "Đang chờ"
                };

                db.LichHens.InsertOnSubmit(newLichHen);
                db.SubmitChanges();

                DialogResult dialogResult = MessageBox.Show("Thêm lịch hẹn thành công!\nBạn có muốn tiếp tục thêm lịch khác?",
                                                            "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialogResult == DialogResult.No)
                {
                    this.Close();
                }
            }
        }

        private PrintDocument printDocument1 = new PrintDocument();

        private void btnIn_Click(object sender, EventArgs e)
        {
            var appointmentInfo = (from bn in db.BenhNhans
                                   where bn.MaBenhNhan == selectedBNId
                                   select new
                                   {
                                       TenBenhNhan = bn.TenBenhNhan,
                                       SDT = bn.SDT,
                                       DiaChi = bn.DiaChi
                                   }).FirstOrDefault();

            if (appointmentInfo == null)
            {
                CustomMessageBox.Show("Không đủ thông tin để lưu", "Lỗi", MessageBoxIcon.Warning);
                return;
            }
            string tenPhongKham = "Derma Clinic";
            string tenBenhNhan = appointmentInfo.TenBenhNhan;
            string ngayHen = dtpNgayHen.Value.ToString("dd/MM/yyyy");
            string khungGio = dtpKhungGio.Value.ToString("HH:mm");
            string ngayLapPhieu = DateTime.Now.ToString("dd/MM/yyyy");

            printDocument1.PrintPage += (s, ev) =>
            {        
                    Font fontTitle = new Font("Times New Roman", 22, FontStyle.Bold);
                    Font fontSubTitle = new Font("Times New Roman", 18, FontStyle.Bold);
                    Font fontContent = new Font("Times New Roman", 12);
                    Font fontFooter = new Font("Times New Roman", 12, FontStyle.Italic);

                    float leftMargin = 100; 
                    float centerMargin = ev.PageBounds.Width / 2;
                    float y = 100;

                    StringFormat centerFormat = new StringFormat
                    {
                        Alignment = StringAlignment.Center,
                        LineAlignment = StringAlignment.Center
                    };
                    ev.Graphics.DrawString(tenPhongKham.ToUpper(), fontTitle, Brushes.DarkBlue, centerMargin, y, centerFormat);
                    y += 60;
                    ev.Graphics.DrawString("PHIẾU XÁC NHẬN LỊCH HẸN", fontSubTitle, Brushes.DarkBlue, centerMargin, y, centerFormat);
                    y += 80;
                    ev.Graphics.DrawString("Thông tin bệnh nhân:", fontSubTitle, Brushes.Black, leftMargin, y);
                    y += 40;
                    ev.Graphics.DrawString($"Họ và tên: {tenBenhNhan}", fontContent, Brushes.Black, leftMargin, y);
                    y += 25;
                    ev.Graphics.DrawString($"Số điện thoại: {appointmentInfo.SDT}", fontContent, Brushes.Black, leftMargin, y);
                    y += 25;
                    ev.Graphics.DrawString($"Địa chỉ: {appointmentInfo.DiaChi}", fontContent, Brushes.Black, leftMargin, y);
                    y += 25;
                    ev.Graphics.DrawString($"Ngày hẹn: {ngayHen}", fontContent, Brushes.Black, leftMargin, y);
                    y += 25;
                    ev.Graphics.DrawString($"Khung giờ: {khungGio}", fontContent, Brushes.Black, leftMargin, y);
                    y += 50;
                    ev.Graphics.DrawString($"Ngày lập phiếu: {ngayLapPhieu}", fontContent, Brushes.Black, leftMargin, y);
                    y += 80;
                    float chuki = 300; 
                    ev.Graphics.DrawString("Người lập phiếu", fontFooter, Brushes.Black, leftMargin, y);
                    ev.Graphics.DrawLine(Pens.Black, leftMargin, y + 20, leftMargin + 200, y + 20);
                    ev.Graphics.DrawString("Xác nhận của bệnh nhân", fontFooter, Brushes.Black, leftMargin + chuki, y);
                    ev.Graphics.DrawLine(Pens.Black, leftMargin + chuki, y + 20, leftMargin + chuki + 200, y + 20);
                };
            using (PrintPreviewDialog preview = new PrintPreviewDialog())
            {
                preview.Document = printDocument1;

                if (preview.ShowDialog() == DialogResult.OK)
                {
                    printDocument1.Print();
                }
            }
        }
        private void CustomizeDgvBenhNhan()
        {
            dgvBenhNhan.Columns[0].HeaderText = "Mã Bệnh Nhân";
            dgvBenhNhan.Columns[1].HeaderText = "Tên Bệnh Nhân";
            dgvBenhNhan.Columns[2].HeaderText = "Số Điện Thoại";
            dgvBenhNhan.Columns[3].HeaderText = "Địa Chỉ";
            dgvBenhNhan.Columns[4].HeaderText = "Giới Tính";

            dgvBenhNhan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvBenhNhan.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvBenhNhan.ColumnHeadersDefaultCellStyle.BackColor = Color.AliceBlue;
            dgvBenhNhan.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgvBenhNhan.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 12, FontStyle.Bold);

            foreach (DataGridViewColumn column in dgvBenhNhan.Columns)
            {
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            }

            dgvBenhNhan.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;
            dgvBenhNhan.DefaultCellStyle.Font = new Font("Times New Roman", 12, FontStyle.Regular);
            dgvBenhNhan.RowHeadersVisible = false;
            dgvBenhNhan.GridColor = Color.LightGray;
            dgvBenhNhan.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvBenhNhan.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            
            dgvBenhNhan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBenhNhan.BackgroundColor = Color.White;
            dgvBenhNhan.EnableHeadersVisualStyles = false;
            dgvBenhNhan.Refresh();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            dgvBenhNhan.ClearSelection();
            dgvBenhNhan.FirstDisplayedScrollingRowIndex = 0;

            txtMaBenhNhan.Text = string.Empty;
            txtTenBenhNhan.Text = string.Empty;
            txtSDT.Text = string.Empty;
            lblDiaChi.Text = string.Empty;
            lblGioiTinh.Text = string.Empty;
            LoadBenhNhanData();                
        }
    }
}
