using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;


namespace Clinix
{
    public partial class KeDonThuoc : Form
    {
        public KeDonThuoc()
        {
            InitializeComponent();
        }
        void loadPhieuKham()
        {
            using (DataClasses2DataContext db = new DataClasses2DataContext())
            {
                db.Connection.Open();

                var listPK = (from pk in db.PhieuKhams
                              join bn in db.BenhNhans
                              on pk.MaBenhNhan equals bn.MaBenhNhan
                              select new
                              {
                                  MaPhieuKham = pk.MaPhieuKham,
                                  MaBenhNhan = bn.MaBenhNhan,
                                  TenBN = bn.TenBenhNhan,
                              }).OrderByDescending(pklist => pklist.MaPhieuKham).ToList();

                dataGridViewPhieuKham.DataSource = listPK;
                db.Connection.Close();
            }
        }
        private string TaoMaDonThuoc()
        {
            using (DataClasses2DataContext db = new DataClasses2DataContext())
            {
                var maMax = db.DonThuocs
                                  .OrderByDescending(ctdt => ctdt.MaDonThuoc)
                                  .Select(ctdt => ctdt.MaDonThuoc)
                                  .FirstOrDefault();
                if (maMax == null)
                {
                    return "DT001";
                }
                string phanSo = maMax.Substring(2);
                int soMoi = int.Parse(phanSo) + 1;
                return "DT" + soMoi.ToString("D3");
            }
        }
        private void dataGridViewPhieuKham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
                DataGridViewRow row = dataGridViewPhieuKham.Rows[e.RowIndex];

                string maPK = row.Cells["MaPhieuKham"].Value.ToString();

                using (DataClasses2DataContext db = new DataClasses2DataContext())
                {
                    db.Connection.Open();

                    var phieuKham = db.PhieuKhams.FirstOrDefault(pk => pk.MaPhieuKham == maPK);

                    if (phieuKham != null)
                    {
                        var benhNhan = db.BenhNhans.FirstOrDefault(bn => bn.MaBenhNhan == phieuKham.MaBenhNhan);

                        if (benhNhan != null)
                        {
                            txtMaBenhNhan.Text = benhNhan.MaBenhNhan;
                            txtHoTen.Text = benhNhan.TenBenhNhan;
                            cbbGioiTinh.SelectedItem = benhNhan.GioiTinh;

                            if (benhNhan.NgaySinh.HasValue)
                            {
                                DateTime ngaySinh = benhNhan.NgaySinh.Value;
                                int tuoi = DateTime.Now.Year - ngaySinh.Year;

                                if (ngaySinh > DateTime.Now.AddYears(-tuoi))
                                {
                                    tuoi--;
                                }
                                txtTuoi.Text = tuoi.ToString();
                            }
                        }
                        txtChanDoan.Text = phieuKham.ChanDoan;
                    }

                    db.Connection.Close();
                }
            }
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            loadPhieuKham();
            loadThuoc();
            txtMaDon.Text = TaoMaDonThuoc();
            var listThuoc = loadThuoc();
            cbbLoaiThuoc.DataSource = listThuoc;
            cbbLoaiThuoc.DisplayMember = "TenThuoc";
            cbbLoaiThuoc.ValueMember = "MaThuoc";

            cbbGioiTinh.Items.Add("Nam");
            cbbGioiTinh.Items.Add("Nữ");
            cbbGioiTinh.SelectedIndex = 0;

            dataGridViewPhieuKham.CellClick += dataGridViewPhieuKham_CellContentClick;
            dataGridViewDonThuoc.CellClick += dataGridViewDonThuoc_CellClick;

            dataGridViewDonThuoc.Columns.Add("MaThuoc", "Mã Thuốc");
            dataGridViewDonThuoc.Columns.Add("TenThuoc", "Tên Thuốc");
            dataGridViewDonThuoc.Columns.Add("DVTinh", "Đơn Vị Tính");
            dataGridViewDonThuoc.Columns.Add("SoLuong", "Số Lượng");
            dataGridViewDonThuoc.Columns.Add("LieuLuong", "Liều Lượng");

            dataGridViewDonThuoc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewDonThuoc.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewDonThuoc.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;
            dataGridViewDonThuoc.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font(dataGridViewDonThuoc.Font, FontStyle.Bold);
            dataGridViewDonThuoc.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Times New Roman", 10, FontStyle.Bold);
            foreach (DataGridViewColumn column in dataGridViewDonThuoc.Columns)
            {
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            }

            dataGridViewDonThuoc.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;

            dataGridViewDonThuoc.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridViewDonThuoc.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            dataGridViewPhieuKham.Columns[0].HeaderText = "Mã phiếu khám";
            dataGridViewPhieuKham.Columns[1].HeaderText = "Mã bệnh nhân";
            dataGridViewPhieuKham.Columns[2].HeaderText = "Tên bệnh nhân";
            dataGridViewPhieuKham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewPhieuKham.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewPhieuKham.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;
            dataGridViewPhieuKham.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Times New Roman", 10, FontStyle.Bold);

            foreach (DataGridViewColumn column in dataGridViewPhieuKham.Columns)
            {
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            }

            dataGridViewPhieuKham.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;

            dataGridViewPhieuKham.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridViewPhieuKham.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }
        private void btnTim_Click(object sender, EventArgs e)
        {
            using (DataClasses2DataContext  db = new DataClasses2DataContext())
            {
                db.Connection.Open();

                var listPK = (from bn in db.BenhNhans
                              join pk in db.PhieuKhams
                              on bn.MaBenhNhan equals pk.MaBenhNhan
                              where bn.MaBenhNhan.Contains(txtTimMP.Text) || bn.TenBenhNhan.Contains(txtTimMP.Text) || pk.MaPhieuKham.Contains(txtTimMP.Text)
                              select new
                              {
                                  MaPhieuKham = pk.MaPhieuKham,
                                  MaBN = bn.MaBenhNhan,
                                  TenBN = bn.TenBenhNhan
                              }).ToList();

                dataGridViewPhieuKham.DataSource = listPK;

                db.Connection.Close();
            }
        }
        List<DSThuoc> loadThuoc()
        {
            using (DataClasses2DataContext db = new DataClasses2DataContext())
            {
                db.Connection.Open();
                var listThuoc = (from t in db.Thuocs
                                 select new DSThuoc
                                 {
                                     MaThuoc = t.MaThuoc,
                                     TenThuoc = t.TenThuoc,
                                     DVTinh = t.DVT,
                                 }).ToList();

                db.Connection.Close();
                return listThuoc;
            }
        }
        public class DSThuoc
        {
            public string MaThuoc { get; set; }
            public string TenThuoc { get; set; }
            public string DVTinh { get; set; }  
        }

        private void btnThemThuoc_Click(object sender, EventArgs e)
        {
            if (cbbLoaiThuoc.SelectedItem != null && !string.IsNullOrWhiteSpace(txtSL.Text))
            {
                string lieuLuong = txtLieuLuong.Text;
                int soLuong = int.Parse(txtSL.Text);
                if (soLuong <= 0)
                {
                    CustomMessageBox.Show("Số lượng phải lớn hơn 0!", "Thông báo", MessageBoxIcon.Warning);
                    return;
                }

                var selectedThuoc = (dynamic)cbbLoaiThuoc.SelectedItem;
                string maThuoc = selectedThuoc.MaThuoc;
                string tenThuoc = selectedThuoc.TenThuoc;
                string dVTinh = selectedThuoc.DVTinh; 

                dataGridViewDonThuoc.Rows.Add(maThuoc, tenThuoc, dVTinh, soLuong, lieuLuong);
            }
            else
            {
                CustomMessageBox.Show("Vui lòng chọn thuốc và nhập số lượng!", "Thông báo", MessageBoxIcon.Warning);
            }
        }
        private void dataGridViewDonThuoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewDonThuoc.Rows[e.RowIndex];

                string maThuoc = row.Cells["MaThuoc"].Value?.ToString();
                string dVTinh = row.Cells["DVTinh"].Value?.ToString();
                string soLuong = row.Cells["SoLuong"].Value?.ToString();
                string lieuLuong = row.Cells["LieuLuong"].Value?.ToString();

                txtSL.Text = soLuong;
                txtLieuLuong.Text = lieuLuong;
                cbbLoaiThuoc.SelectedValue = maThuoc;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            txtMaDon.Text = "";
            txtMaBenhNhan.Text = "";
            cbbGioiTinh.SelectedIndex = -1;  
            txtHoTen.Text = " ";
            txtTuoi.Text = " ";
            dataGridViewDonThuoc.Rows.Clear();
            txtLieuLuong.Text = " ";
            txtSL.Text = " ";
            txtChanDoan.Text = " ";
            txtGhiChu.Text = " ";
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            

            Menu trangChu = new Menu();
            trangChu.Show();
        }
        private void btnXoaThuoc_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewDonThuoc.CurrentRow != null)
                {
                    int rowIndex = dataGridViewDonThuoc.CurrentRow.Index;
                    dataGridViewDonThuoc.Rows.RemoveAt(rowIndex);
                    txtLieuLuong.Clear();
                    txtSL.Clear();
                    cbbLoaiThuoc.SelectedIndex = -1;
                }
                else
                {
                    CustomMessageBox.Show("Vui lòng chọn dòng để xóa.", "Thông báo", MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show("Lỗi khi xóa dòng: " + ex.Message, "Lỗi", MessageBoxIcon.Error);
            }
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            {
                txtMaDon.Text = TaoMaDonThuoc();

                if (string.IsNullOrWhiteSpace(txtMaDon.Text))
                {
                    CustomMessageBox.Show("Vui lòng nhập Mã Đơn Thuốc!", "Thông báo", MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtMaBenhNhan.Text))
                {
                    CustomMessageBox.Show("Vui lòng chọn Phiếu Khám để lấy thông tin bệnh nhân!", "Thông báo", MessageBoxIcon.Warning);
                    return;
                }

                if (dataGridViewDonThuoc.Rows.Count == 0)
                {
                    CustomMessageBox.Show("Danh sách thuốc không được để trống!", "Thông báo", MessageBoxIcon.Warning);
                    return;
                }
                string maDonThuoc = txtMaDon.Text.Trim();
                string maPhieuKham = dataGridViewPhieuKham.CurrentRow?.Cells["MaPhieuKham"].Value?.ToString();
                string ghiChu = txtGhiChu.Text.Trim();
                DateTime ngayKeDon = dateTimePicker2.Value;

                if (string.IsNullOrWhiteSpace(maPhieuKham))
                {
                    CustomMessageBox.Show("Không tìm thấy Mã Phiếu Khám! Vui lòng chọn lại từ danh sách.", "Thông báo", MessageBoxIcon.Warning);
                    return;
                }
                using (DataClasses2DataContext db = new DataClasses2DataContext())
                {
                    db.Connection.Open();

                    DonThuoc newDonThuoc = new DonThuoc
                    {
                        MaDonThuoc = maDonThuoc,
                        NgayKeDon = ngayKeDon,
                        GhiChu = ghiChu,
                        MaPhieuKham = maPhieuKham,
                    };
                    db.DonThuocs.InsertOnSubmit(newDonThuoc);
                    db.SubmitChanges();

                    db.Connection.Close();
                }          

                List<ChiTietDonThuoc> chiTietDonThuocs = new List<ChiTietDonThuoc>();

                foreach (DataGridViewRow row in dataGridViewDonThuoc.Rows)
                {
                    if (row.IsNewRow) continue;

                    string maThuoc = row.Cells["MaThuoc"].Value?.ToString();
                    string lieuLuong = row.Cells["LieuLuong"].Value?.ToString();
                    string dVTinh = row.Cells["dVTinh"].Value?.ToString();
                    string soLuongStr = row.Cells["SoLuong"].Value?.ToString();

                    if (string.IsNullOrWhiteSpace(maThuoc) || string.IsNullOrWhiteSpace(soLuongStr))
                    {
                        CustomMessageBox.Show("Dữ liệu thuốc không hợp lệ!", "Thông báo", MessageBoxIcon.Warning);
                        return;
                    }

                    if (!int.TryParse(soLuongStr, out int soLuong) || soLuong <= 0)
                    {
                        CustomMessageBox.Show("Số lượng thuốc phải là số nguyên dương!", "Thông báo", MessageBoxIcon.Warning);
                        return;
                    }
                    using (DataClasses2DataContext db = new DataClasses2DataContext())
                    {
                        db.Connection.Open();

                        ChiTietDonThuoc newChiTietDonThuoc = new ChiTietDonThuoc
                        {
                            MaDonThuoc = maDonThuoc,
                            MaThuoc = maThuoc,
                            LieuLuong = lieuLuong,
                            SoLuong = soLuong
                        };
                        db.ChiTietDonThuocs.InsertOnSubmit(newChiTietDonThuoc);
                        db.SubmitChanges();

                        db.Connection.Close();
                    }
                    CustomMessageBox.Show("Lưu đơn thuốc thành công.", "Thông báo", MessageBoxIcon.Information);
                }
            }

        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            if (dataGridViewPhieuKham.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewPhieuKham.SelectedRows[0];

                string maPhieuKham = selectedRow.Cells["MaPhieuKham"].Value.ToString();

                if (!string.IsNullOrEmpty(maPhieuKham))
                {
                    KeToa keToa = new KeToa(maPhieuKham);
                    keToa.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Mã phiếu khám không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một phiếu khám để in!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (DataClasses2DataContext db = new DataClasses2DataContext())
            {
                db.Connection.Open();

                var listPK = (from bn in db.BenhNhans
                              join pk in db.PhieuKhams
                              on bn.MaBenhNhan equals pk.MaBenhNhan
                              where bn.MaBenhNhan.Contains(txtTimMP.Text) || bn.TenBenhNhan.Contains(txtTimMP.Text) || pk.MaPhieuKham.Contains(txtTimMP.Text)
                              select new
                              {
                                  MaPhieuKham = pk.MaPhieuKham,
                                  MaBN = bn.MaBenhNhan,
                                  TenBN = bn.TenBenhNhan
                              }).ToList();

                dataGridViewPhieuKham.DataSource = listPK;

                db.Connection.Close();
            }
        }
    }
}

