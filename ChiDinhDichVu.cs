using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;


namespace Clinix
{
    public partial class ChiDinhDichVu : Form
    {
        public ChiDinhDichVu()
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
        private void Form2_Load(object sender, EventArgs e)
        {
            dataGridViewDV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewDV.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewDV.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;

            foreach (DataGridViewColumn column in dataGridViewDV.Columns)
            {
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            }

            dataGridViewDV.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;
            dataGridViewDV.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridViewDV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            loadPhieuKham();
            loadDichVu();

          
            var listDichVu = loadDichVu();
            cbbDV.DataSource = listDichVu;
            cbbDV.DisplayMember = "TenDichVu";
            cbbDV.ValueMember = "MaDichVu";

            dataGridViewDV.Columns.Add("MaDV", "Mã dịch vụ");
            dataGridViewDV.Columns.Add("TenDV", "Tên dịch vụ");
            dataGridViewDV.Columns.Add("SoLuong", "Số lượng");
            dataGridViewDV.Columns.Add("DonGia", "Đơn giá");
            dataGridViewDV.Columns.Add("ThanhTien", "Thành tiền");

            dataGridViewPhieuKham.CellClick += dataGridViewPhieuKham_CellContentClick;
            dataGridViewDV.CellClick += dataGridViewDV_CellClick;

            dataGridViewPhieuKham.Columns[0].HeaderText = "Mã phiếu khám";
            dataGridViewPhieuKham.Columns[1].HeaderText = "Mã bệnh nhân";
            dataGridViewPhieuKham.Columns[2].HeaderText = "Tên bệnh nhân";

            dataGridViewPhieuKham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewPhieuKham.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft ;
            dataGridViewPhieuKham.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;

            foreach (DataGridViewColumn column in dataGridViewPhieuKham.Columns)
            {
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            }

            dataGridViewPhieuKham.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;
            dataGridViewPhieuKham.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridViewPhieuKham.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
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
        List<DSDichVu> loadDichVu()
        {
            using (DataClasses2DataContext db = new DataClasses2DataContext())
            {
                return (from dv in db.DichVus
                        select new DSDichVu
                        {
                            MaDichVu = dv.MaDichVu,
                            TenDichVu = dv.TenDichVu,
                            DonGia = dv.DonGia ?? 0
                        }).ToList();
            }
        }
        public class DSDichVu
        {
            public string MaDichVu { get; set; }
            public string TenDichVu { get; set; }
            public decimal DonGia { get; set; }

        }

        private void btnThemDV_Click(object sender, EventArgs e)
        {
            if (cbbDV.SelectedItem is DSDichVu selectedDV && int.TryParse(txtSL.Text, out int soLuong) && soLuong > 0)
            {
                decimal thanhTien = soLuong * selectedDV.DonGia;
                dataGridViewDV.Rows.Add(selectedDV.MaDichVu, selectedDV.TenDichVu, soLuong, selectedDV.DonGia, thanhTien);
            }
            else
            {
                CustomMessageBox.Show("Vui lòng chọn dịch vụ và nhập số lượng hợp lệ!", "Thông báo",  MessageBoxIcon.Warning);
            }
        }
      

        private void dataGridViewDV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewDV.Rows[e.RowIndex];

                string maDV = row.Cells["MaDV"].Value?.ToString();
                string soLuong = row.Cells["SoLuong"].Value?.ToString();

                txtSL.Text = soLuong;
                cbbDV.SelectedValue = maDV;
            }
        }
 
        private void btnNhapMoi_Click(object sender, EventArgs e)
        {
            txtMaBenhNhan.Text = "";
            txtHoTen.Text = " ";
            txtTuoi.Text = " ";
            dataGridViewDV.Rows.Clear();
            txtSL.Text = " ";
            txtChanDoan.Text = " ";
        }

        private void btnXoaDV_Click(object sender, EventArgs e)
        { 
            if (dataGridViewDV.CurrentRow != null)
            {
                int rowIndex = dataGridViewDV.CurrentRow.Index;
                dataGridViewDV.Rows.RemoveAt(rowIndex);
                txtSL.Clear();
                cbbDV.SelectedIndex = -1;
            }
            else
            {
                CustomMessageBox.Show("Vui lòng chọn dòng để xóa.", "Thông báo",  MessageBoxIcon.Warning);
            }    
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {  
            if (string.IsNullOrWhiteSpace(txtMaBenhNhan.Text))
            {
                CustomMessageBox.Show("Vui lòng nhập Mã Bệnh Nhân!", "Thông báo",  MessageBoxIcon.Warning);
                return;
            }
           

            if (dataGridViewDV.Rows.Count == 0)
            {
                CustomMessageBox.Show("Danh sách dịch vụ không được để trống!", "Thông báo",  MessageBoxIcon.Warning);
                return;
            }

            string maPhieuKham = dataGridViewPhieuKham.Rows[0].Cells["MaPhieuKham"].Value?.ToString();
            string maDV = dataGridViewDV.Rows[0].Cells["MaDV"].Value?.ToString();

            using (DataClasses2DataContext db = new DataClasses2DataContext())
            {
                db.Connection.Open();

                    PhieuChiDinh newPCD = new PhieuChiDinh
                    {
                        MaPhieuKham = maPhieuKham,
                        MaDichVu = maDV
                    };

                    db.PhieuChiDinhs.InsertOnSubmit(newPCD);
                    db.SubmitChanges();

                CustomMessageBox.Show("Lưu thành công!", "Thông báo",  MessageBoxIcon.Information);
                {
                    db.Connection.Close();
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {

            Menu trangChu = new Menu();
            trangChu.Show();
        }

        private void btnTim_Click_1(object sender, EventArgs e)
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

        private void btnIn_Click(object sender, EventArgs e)
        {
            if (dataGridViewPhieuKham.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewPhieuKham.SelectedRows[0];

                string maPhieuKham = selectedRow.Cells["MaPhieuKham"].Value.ToString();

                if (!string.IsNullOrEmpty(maPhieuKham))
                {
                    ChiDinh chiDinh = new ChiDinh(maPhieuKham);
                    chiDinh.ShowDialog();
                }
                else
                {
                    CustomMessageBox.Show("Mã phiếu khám không hợp lệ!", "Thông báo",  MessageBoxIcon.Warning);
                }
            }
            else
            {
                CustomMessageBox.Show("Vui lòng chọn một phiếu khám để in!", "Thông báo",  MessageBoxIcon.Warning);
            }
        }

        private void txtTong_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
