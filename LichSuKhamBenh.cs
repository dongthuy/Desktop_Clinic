using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Clinix
{
    public partial class LichSuKhamBenh : Form
    {
        public LichSuKhamBenh()
        {
            InitializeComponent();
        }
        DataClasses2DataContext db = new DataClasses2DataContext();

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadPatientData();

            string[] headersBenhNhan = { "Mã Bệnh Nhân", "Tên Bệnh Nhân", "Ngày Sinh", "Giới Tính", "Địa Chỉ", "Số Điện Thoại" };
            CustomizeDataGridView(dgvBenhNhan, headersBenhNhan);

            string[] headersBenhAn = { "Mã Phiếu Khám", "Mã Dịch Vụ", "Ngày Khám", "Chẩn Đoán", "Tên Dịch Vụ" };
            CustomizeDataGridView(dgvBenhAn, headersBenhAn);

            txtSearch.Enter += txtSearch_MouseEnter;
            txtSearch.Leave += txtSearch_MouseLeave;
            dgvBenhAn.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBenhNhan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void LoadPatientData()
        {
            var patients = from bn in db.BenhNhans
                           select new
                           {
                               bn.MaBenhNhan,
                               bn.TenBenhNhan,
                               bn.NgaySinh,
                               bn.GioiTinh,
                               bn.DiaChi,
                               bn.SDT
                           };

            dgvBenhNhan.DataSource = patients.ToList();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            var patients = from bn in db.BenhNhans
                           where bn.TenBenhNhan.Contains(txtSearch.Text)
                              || bn.SDT.Contains(txtSearch.Text)
                           select new
                           {
                               bn.MaBenhNhan,
                               bn.TenBenhNhan,
                               bn.NgaySinh,
                               bn.GioiTinh,
                               bn.DiaChi,
                               bn.SDT
                           };

            dgvBenhNhan.DataSource = patients.ToList();

            if (!patients.Any())

                CustomMessageBox.Show("Không tìm thấy bệnh nhân tương ứng", "Thông báo", MessageBoxIcon.Warning);
        }

        private void dgvBenhNhan_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                string selectedMaBenhNhan = dgvBenhNhan.Rows[e.RowIndex].Cells["MaBenhNhan"].Value.ToString();

                var medicalHistory = from pk in db.PhieuKhams
                                     join pd in db.PhieuChiDinhs on pk.MaPhieuKham equals pd.MaPhieuKham
                                     join dv in db.DichVus on pd.MaDichVu equals dv.MaDichVu
                                     where pk.MaBenhNhan == selectedMaBenhNhan
                                     select new
                                     {
                                         pk.MaPhieuKham,
                                         pd.MaDichVu,
                                         pk.NgayKham,
                                         pk.ChanDoan,
                                         dv.TenDichVu
                                     };

                dgvBenhAn.DataSource = medicalHistory.ToList();
            }
        }

        private void txtSearch_MouseEnter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Vui lòng nhập tên hoặc số điện thoại")
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.Black;
            }
        }

        private void txtSearch_MouseLeave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                txtSearch.Text = "Vui lòng nhập tên hoặc số điện thoại";
                txtSearch.ForeColor = Color.Gray; 
            }
        }
        private void CustomizeDataGridView(DataGridView dgv, string[] headers)
        {
            for (int i = 0; i < headers.Length && i < dgv.Columns.Count; i++)
            {
                dgv.Columns[i].HeaderText = headers[i];
            }

            //dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.AliceBlue;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 8, FontStyle.Bold);

            foreach (DataGridViewColumn column in dgv.Columns)
            {
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            }
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;

            dgv.DefaultCellStyle.Font = new Font("Times New Roman", 8, FontStyle.Regular);
            dgv.BackgroundColor = Color.White;

            dgv.RowHeadersVisible = false;
            dgv.GridColor = Color.LightGray;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv.EnableHeadersVisualStyles = false;
            dgv.Refresh();
        }
    }
}
        
        
    

