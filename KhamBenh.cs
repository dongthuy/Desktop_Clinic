using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Clinix
{
    public partial class KhamBenh : Form
    {
        public KhamBenh()
        {
            InitializeComponent();
        }

        void loadBenhNhan()
        {
            using (DataClasses2DataContext db = new DataClasses2DataContext())
            {
                db.Connection.Open();

                var listBN = (from bn in db.BenhNhans
                              select new
                              {
                                  MaBN = bn.MaBenhNhan,
                                  TenBN = bn.TenBenhNhan,
                              }).OrderBy(bnlist => bnlist.MaBN).ToList();

                dgvBN.DataSource = listBN;
                db.Connection.Close();
            }
        }

        List<BacSiViewModel> loadBacSi()
        {
            using (DataClasses2DataContext db = new DataClasses2DataContext())
            {
                db.Connection.Open();
                var listBS = (from bs in db.BacSis
                              join nd in db.NguoiDungs
                              on bs.MaNguoiDung equals nd.MaNguoiDung
                              select new BacSiViewModel
                              {
                                  MaBacSi = bs.MaBacSi,
                                  HoTen = nd.HoTen
                              }).ToList();

                db.Connection.Close();
                return listBS;
            }
        }
        List<DichVu> loadDV()
        {
            DataClasses2DataContext         db = new DataClasses2DataContext();
            db.Connection.Open();

            var listDV = from dv in db.DichVus
                         select dv;
            db.Connection.Close();
            return listDV.ToList();
        }

        public class BacSiViewModel
        {
            public string MaNguoiDung { get; set; }
            public string HoTen { get; set; }
            public string MaBacSi { get; set; }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            txtMaPhieu.Text = TaoMaPhieuKham(); 
            loadBenhNhan();
            cbbGioiTinh.Items.Add("Nam");
            cbbGioiTinh.Items.Add("Nữ");
            cbbGioiTinh.SelectedIndex = 0;

            cbbBSi.DataSource = loadBacSi();
            cbbBSi.DisplayMember = "HoTen";
            cbbBSi.ValueMember = "MaBacSi";
           
            dgvBN.CellClick += dataGridViewBN_CellContentClick;

            dgvBN.Columns[0].HeaderText = "Mã bệnh nhân";
            dgvBN.Columns[1].HeaderText = "Tên bệnh nhân";

            dgvBN.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            
            dgvBN.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvBN.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;
            
            dgvBN.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Times New Roman", 10, FontStyle.Bold);

            foreach (DataGridViewColumn column in  dgvBN.Columns)
            {
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            }
            dgvBN.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;

            dgvBN.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvBN.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }
        private void dataGridViewBN_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
              
                DataGridViewRow row = dgvBN.Rows[e.RowIndex];
                string maBN = row.Cells["MaBN"].Value.ToString();

                using (DataClasses2DataContext db = new DataClasses2DataContext())
                {
                    db.Connection.Open();

                    var benhNhan = db.BenhNhans.FirstOrDefault(bn => bn.MaBenhNhan == maBN);
                    if (benhNhan != null)
                    {
                        if (benhNhan.NgaySinh.HasValue) 
                        {
                            dateTimeNgaySinh.Value = benhNhan.NgaySinh.Value;
                        }
                        else
                        {
                            dateTimeNgaySinh.Value = DateTime.Now; 
                        }
                        txtMaBN.Text = benhNhan.MaBenhNhan;
                        txtHoTen.Text = benhNhan.TenBenhNhan;
                        txtSDT.Text = benhNhan.SDT;
                        txtDiaChi.Text = benhNhan.DiaChi;
                        cbbGioiTinh.SelectedItem = benhNhan.GioiTinh;
                    }

                    db.Connection.Close();
                }
            }
        }
        private void btnTim_Click(object sender, EventArgs e)
        {
            using (DataClasses2DataContext db = new DataClasses2DataContext())
            {
                db.Connection.Open();

                var listBN = (from bn in db.BenhNhans
                              where bn.MaBenhNhan.Contains(txtTim.Text) || bn.TenBenhNhan.Contains(txtTim.Text)
                              select new
                              {
                                  MaBN = bn.MaBenhNhan,
                                  TenBN = bn.TenBenhNhan
                              }).ToList();

                dgvBN.DataSource = listBN;

                db.Connection.Close();
            }
        }

        private void dateTimeNgaySinh_ValueChanged(object sender, EventArgs e)
        {
            {
                DateTime ngaySinh = dateTimeNgaySinh.Value;
                int tuoi = Tuoi(ngaySinh);

                txtTuoi.Text = tuoi.ToString();
            }
        }
        private int Tuoi(DateTime ngaySinh)
        {
            DateTime ngayHienTai = DateTime.Now;
            int tuoi = ngayHienTai.Year - ngaySinh.Year;

            if (ngayHienTai.Month < ngaySinh.Month ||
               (ngayHienTai.Month == ngaySinh.Month && ngayHienTai.Day < ngaySinh.Day))
            {
                tuoi--;
            }

            return tuoi;
        }

        private void btnNhapMoi_Click(object sender, EventArgs e)
        {
            txtMaBN.Text = "";
            cbbGioiTinh.SelectedIndex = -1;   
            txtHoTen.Text = " ";
            txtDiaChi.Text = " ";
            txtSDT.Text = " ";
            dateTimeNgaySinh.Value = DateTime.Now;
            txtTuoi.Text = " ";
            txtChanDoan.Text = " ";
        }
        private string TaoMaPhieuKham()
        {
            using (DataClasses2DataContext db = new DataClasses2DataContext())
            {
                var maMax = db.PhieuKhams
                                  .OrderByDescending(pk => pk.MaPhieuKham)
                                  .Select(pk => pk.MaPhieuKham)
                                  .FirstOrDefault();

                if (maMax == null)
                {
                    return "PK001";
                }

                string phanSo = maMax.Substring(2);
                int soMoi = int.Parse(phanSo) + 1;

                return "PK" + soMoi.ToString("D3");
            }
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            txtMaPhieu.Text = TaoMaPhieuKham();
            string maPhieuKham = txtMaPhieu.Text;
            string chanDoan = txtChanDoan.Text;
            DateTime ngayKham = dateTimePicker1.Value;
            string maBacSi = cbbBSi.SelectedValue.ToString(); // Lấy mã bác sĩ từ ComboBox
            string maBenhNhan = txtMaBN.Text;

            if (string.IsNullOrEmpty(maPhieuKham) || string.IsNullOrEmpty(chanDoan) || string.IsNullOrEmpty(maBacSi) || string.IsNullOrEmpty(maBenhNhan))
            {
                CustomMessageBox.Show("Vui lòng điền đầy đủ thông tin.", "Thông báo", MessageBoxIcon.Warning);
                return;
            }

            using (DataClasses2DataContext db = new DataClasses2DataContext())
            {
                db.Connection.Open();

                PhieuKham newPhieuKham = new PhieuKham
                {
                    MaPhieuKham = maPhieuKham,
                    ChanDoan = chanDoan,
                    NgayKham = ngayKham,
                    MaBacSi = maBacSi,
                    MaBenhNhan = maBenhNhan
                };

                db.PhieuKhams.InsertOnSubmit(newPhieuKham);
                db.SubmitChanges();

                db.Connection.Close();
            }

            CustomMessageBox.Show("Lưu phiếu khám thành công.", "Thông báo", MessageBoxIcon.Information);
            ResetForm();
        }
        private void ResetForm()
        {
            txtMaPhieu.Text = string.Empty;
            txtChanDoan.Text = string.Empty;


            cbbGioiTinh.SelectedIndex = -1;
            dateTimeNgaySinh.Value = DateTime.Now;

            txtMaBN.Text = string.Empty;
            txtHoTen.Text = string.Empty;
            txtTuoi.Text = string.Empty;
            txtSDT.Text = string.Empty;
            txtDiaChi.Text = string.Empty;        
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtMaBN.Text = string.Empty;
            txtHoTen.Text = string.Empty;
            txtDiaChi.Text = string.Empty;
            txtSDT.Text = string.Empty;
            txtTuoi.Text = string.Empty;

            if (cbbGioiTinh.Items.Count > 0)
                cbbGioiTinh.SelectedIndex = -1; 
          
            dateTimeNgaySinh.Value = DateTime.Now;
 
            CustomMessageBox.Show("Đã xóa thông tin!", "Thông báo", MessageBoxIcon.Information);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string ChanDoan = txtChanDoan.Text;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Menu trangChu = new Menu();
            trangChu.Show();
        }


        private void kêToaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KeDonThuoc kdt = new KeDonThuoc();
            kdt.ShowDialog();
        }

        private void chỉĐịnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChiDinhDichVu form2 = new ChiDinhDichVu();
            form2.ShowDialog();
        }

        private void lịchSửKCBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LichSuKhamBenh ls = new LichSuKhamBenh();
            ls.ShowDialog();
        }
    }

}
