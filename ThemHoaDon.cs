using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Clinix

{
    public partial class frmThemHoaDon : Form
    {
        DataClasses2DataContext da = new DataClasses2DataContext();

        public string MaPhieuKham { get; set; }
        public decimal TongDonGia { get; set; }

        public frmThemHoaDon()
        {
            InitializeComponent();
        }

        private void frmThemHoaDon_Load(object sender, EventArgs e)
        {
            txtMaPK.Text = MaPhieuKham;
            txtMaPK.ReadOnly = true;

            txtTongTien.Text = TongDonGia.ToString("N2", System.Globalization.CultureInfo.GetCultureInfo("vi-VN")); // Định dạng số mà không có ký hiệu tiền tệ
            txtTongTien.ReadOnly = true;

            txtMaHD.ReadOnly = true;
            var maxMaHD = da.HoaDons
                    .Select(hd => hd.MaHoaDon)
                    .OrderByDescending(ma => ma)
                    .FirstOrDefault();

            if (maxMaHD != null)
            {
                string prefix = "HD";
                string numberPart = maxMaHD.Substring(prefix.Length);
                if (int.TryParse(numberPart, out int currentMax))
                {
                    txtMaHD.Text = prefix + (currentMax + 1).ToString();
                }
                else
                {
                    txtMaHD.Text = prefix + "1";
                }
            }
            else
            {
                txtMaHD.Text = "HD1";
            }

            var maPKList = da.PhieuKhams.Select(pk => new { pk.MaPhieuKham }).Distinct().ToList();
            maPKList.Insert(0, new { MaPhieuKham = " " });

            cboMaPK.DataSource = maPKList;
            cboMaPK.DisplayMember = "MaPhieuKham";
            cboMaPK.ValueMember = "MaPhieuKham";

            var maLTList = da.LeTans.Select(lt => new { lt.MaLeTan }).Distinct().ToList();
            maLTList.Insert(0, new { MaLeTan = "Chọn Mã Lễ Tân" });
            cboMaLT.DataSource = maLTList;
            cboMaLT.DisplayMember = "MaLeTan";
            cboMaLT.ValueMember = "MaLeTan";

            var trangThaiList = new List<string> { "Chưa thanh toán", "Đã thanh toán", "Đã hủy" };
            trangThaiList.Insert(0, "Chọn Trạng Thái");
            cboTrangThai.DataSource = trangThaiList;

            var hinhThucList = new List<string> { "Tiền mặt", "Chuyển khoản", "Thẻ tín dụng" };
            hinhThucList.Insert(0, "Chọn Hình Thức");
            cboHinhThuc.DataSource = hinhThucList;

            //HoaDon
            var listHoaDon = from hd in da.HoaDons
                             join lt in da.LeTans on hd.MaLeTan equals lt.MaLeTan
                             join pk in da.PhieuKhams on hd.MaPhieuKham equals pk.MaPhieuKham
                             select new
                             {
                                 hd.MaHoaDon,
                                 pk.MaPhieuKham,
                                 hd.SoTien,
                                 hd.PhuongThucTT,
                                 hd.TrangThai,
                                 hd.ThoiGianTT,
                                 hd.GhiChu,
                                 lt.MaLeTan
                             };
            dgvHoaDon.DataSource = listHoaDon.ToList();
            dgvHoaDon.Columns[0].HeaderText = "Mã hóa đơn";
            dgvHoaDon.Columns[1].HeaderText = "Mã phiếu khám";
            dgvHoaDon.Columns[2].HeaderText = "Số tiền";
            dgvHoaDon.Columns[3].HeaderText = "Hình thức thanh toán";
            dgvHoaDon.Columns[4].HeaderText = "Trạng thái";
            dgvHoaDon.Columns[5].HeaderText = "Thời gian thanh toán";
            dgvHoaDon.Columns[6].HeaderText = "Ghi chú";
            dgvHoaDon.Columns[7].HeaderText = "Mã lễ tân";

            dgvHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHoaDon.Columns[0].Width = 60;
            dgvHoaDon.Columns[1].Width = 70;
            dgvHoaDon.Columns[2].Width = 60;
            dgvHoaDon.Columns[3].Width = 100;
            dgvHoaDon.Columns[4].Width = 100;
            dgvHoaDon.Columns[5].Width = 100;
            dgvHoaDon.Columns[6].Width = 70;
            dgvHoaDon.Columns[7].Width = 80;

            dgvHoaDon.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvHoaDon.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;

            foreach (DataGridViewColumn column in dgvHoaDon.Columns)
            {
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            dgvHoaDon.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;

            dgvHoaDon.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvHoaDon.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboMaPK_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedMaPK = cboMaPK.SelectedValue?.ToString();

            if (!string.IsNullOrEmpty(selectedMaPK))
            {
                var locDuLieu = from hd in da.HoaDons
                                   join lt in da.LeTans on hd.MaLeTan equals lt.MaLeTan
                                   join pk in da.PhieuKhams on hd.MaPhieuKham equals pk.MaPhieuKham
                                   where pk.MaPhieuKham == selectedMaPK 
                                   select new
                                   {
                                       hd.MaHoaDon,
                                       pk.MaPhieuKham,
                                       hd.SoTien,
                                       hd.PhuongThucTT,
                                       hd.TrangThai,
                                       hd.ThoiGianTT,
                                       hd.GhiChu,
                                       lt.MaLeTan
                                   };
                dgvHoaDon.DataSource = locDuLieu.ToList();
            }
            else
            {
                var allData = from hd in da.HoaDons
                              join lt in da.LeTans on hd.MaLeTan equals lt.MaLeTan
                              join pk in da.PhieuKhams on hd.MaPhieuKham equals pk.MaPhieuKham
                              select new
                              {
                                  hd.MaHoaDon,
                                  pk.MaPhieuKham,
                                  hd.SoTien,
                                  hd.PhuongThucTT,
                                  hd.TrangThai,
                                  hd.ThoiGianTT,
                                  hd.GhiChu,
                                  lt.MaLeTan
                              };
                dgvHoaDon.DataSource = allData.ToList();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cboMaLT.SelectedValue?.ToString()) ||
                cboMaLT.SelectedValue.ToString() == "Chọn Mã Lễ Tân" ||
                string.IsNullOrEmpty(cboTrangThai.SelectedItem?.ToString()) ||
                cboTrangThai.SelectedItem.ToString() == "Chọn Trạng Thái" ||
                string.IsNullOrEmpty(cboHinhThuc.SelectedItem?.ToString()) ||
                cboHinhThuc.SelectedItem.ToString() == "Chọn Hình Thức" ||
                dtpThoiGianTT.Value == dtpThoiGianTT.MinDate)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maPhieuKham = cboMaPK.SelectedValue?.ToString();

            var phieuKhamInfo = da.PhieuKhams.FirstOrDefault(pk => pk.MaPhieuKham == maPhieuKham);
            if (phieuKhamInfo == null)
            {
                MessageBox.Show("Không tìm thấy thông tin phiếu khám!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            HoaDon newHoaDon = new HoaDon
            {
                MaHoaDon = txtMaHD.Text.Trim(),
                MaPhieuKham = maPhieuKham,
                MaLeTan = cboMaLT.SelectedValue.ToString(),
                SoTien = TongDonGia,
                PhuongThucTT = cboHinhThuc.SelectedItem.ToString(),
                TrangThai = cboTrangThai.SelectedItem.ToString(),
                ThoiGianTT = TimeSpan.Parse(dtpThoiGianTT.Value.ToString("HH:mm:ss")),
                GhiChu = txtGhiChu.Text.Trim()
            };

            da.HoaDons.InsertOnSubmit(newHoaDon);

            try
            {
                da.SubmitChanges();
                MessageBox.Show("Thêm hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                var listHoaDon = from hd in da.HoaDons
                                 join lt in da.LeTans on hd.MaLeTan equals lt.MaLeTan
                                 select new
                                 {
                                     hd.MaHoaDon,
                                     hd.SoTien,
                                     hd.PhuongThucTT,
                                     hd.TrangThai,
                                     hd.ThoiGianTT,
                                     hd.GhiChu,
                                     lt.MaLeTan
                                 };
                dgvHoaDon.DataSource = listHoaDon.ToList();

                int newRowIndex = dgvHoaDon.Rows.Count - 1;
                dgvHoaDon.Rows[newRowIndex].Selected = true;
                dgvHoaDon.CurrentCell = dgvHoaDon.Rows[newRowIndex].Cells[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message + "\\n" + ex.StackTrace, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnInPhieu_Click(object sender, EventArgs e)
        {
            if (dgvHoaDon.SelectedRows.Count > 0)
            {
                var selectedRow = dgvHoaDon.SelectedRows[0];

                string maHoaDon = selectedRow.Cells["MaHoaDon"].Value.ToString();

                if (!string.IsNullOrEmpty(maHoaDon))
                {
                    frmInHoaDon frm = new frmInHoaDon();
                    frm.MaHoaDon = maHoaDon;
                    frm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Mã hóa đơn không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hóa đơn để in!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
