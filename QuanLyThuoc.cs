using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Clinix
{
    public partial class QuanLyThuoc : Form
    {
        public QuanLyThuoc()
        {
            InitializeComponent();
        }

        private void LoadThuoc()
        {
           DataClasses2DataContext db = new DataClasses2DataContext();

            db.Connection.Open();

            var taiLen = from thuoc in db.Thuocs
                         select new
                         {
                             MaThuoc = thuoc.MaThuoc,
                             TenThuoc = thuoc.TenThuoc,
                             DonViTinh = thuoc.DVT,
                             MoTa = thuoc.MoTa
                         };
            txtTimfrmThuoc.Clear();

            dgvThuoc.DataSource = taiLen.ToList();
            dgvThuoc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvThuoc.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvThuoc.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;
            dgvThuoc.ColumnHeadersDefaultCellStyle.Font = new Font(dgvThuoc.Font, FontStyle.Bold);

            foreach (DataGridViewColumn column in dgvThuoc.Columns)
            {
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            }

            dgvThuoc.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;

            dgvThuoc.Columns["MaThuoc"].Width = 150; 
            dgvThuoc.Columns["TenThuoc"].Width = 250; 
            dgvThuoc.Columns["DonViTinh"].Width = 100; 
            dgvThuoc.Columns["MoTa"].Width = 500; 

            dgvThuoc.Columns["MaThuoc"].HeaderText = "Mã Thuốc";
            dgvThuoc.Columns["TenThuoc"].HeaderText = "Tên Thuốc";
            dgvThuoc.Columns["DonViTinh"].HeaderText = "Đơn Vị Tính";
            dgvThuoc.Columns["MoTa"].HeaderText = "Mô Tả";

            db.Connection.Close();
        }

        private void frmThuoc_Load(object sender, EventArgs e)
        {
            LoadThuoc();

        }

        private void btnTimfrmThuoc_Click(object sender, EventArgs e)
        {
            DataClasses2DataContext db = new DataClasses2DataContext();
            db.Connection.Open();

            var TimKiem = from thuoc in db.Thuocs
                          where thuoc.TenThuoc.Contains(txtTimfrmThuoc.Text)
                          || thuoc.MoTa.Contains(txtTimfrmThuoc.Text)
                          select thuoc;
            dgvThuoc.DataSource = TimKiem;
            db.Connection.Close();
        }

        private void btnDongfrmThuoc_Click(object sender, EventArgs e)
        {

            Menu trangChu = new Menu();
            trangChu.Show(); this.Close();
        }

        private void XuatExcel (string duongDan)
        {
            Excel.Application app = new Excel.Application();
            app.Application.Workbooks.Add(Type.Missing);

            for (int i = 0; i < dgvThuoc.Columns.Count; i++)
            {
                app.Cells[1, i + 1] = dgvThuoc.Columns[i].HeaderText;
            }
            for (int i = 0; i < dgvThuoc.Rows.Count; i++)
            {
                for (int j = 0; j < dgvThuoc.Columns.Count; j++)
                {
                    app.Cells[i + 2, j + 1] = dgvThuoc.Rows[i].Cells[j].Value;
                }
            }
            app.Columns.AutoFit();
            app.ActiveWorkbook.SaveCopyAs(duongDan);
            app.ActiveWorkbook.Saved = true;

        }

        private void btnXuatfrmThuoc_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Title = "Danh sách Thuốc";
            save.Filter = "Excel (*.xlsx)|*.xlsx";
            if(save.ShowDialog()==DialogResult.OK)
            {
                try
                {
                    XuatExcel(save.FileName);
                    MessageBox.Show("Xuất file thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xuất file không thành công!\n" + ex.Message);
                }
            }    
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadThuoc();
        }
    }
}
