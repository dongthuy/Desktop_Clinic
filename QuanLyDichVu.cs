using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Clinix
{
    public partial class QuanLyDichVu : Form
    {
        public QuanLyDichVu()
        {
            InitializeComponent();
           
            toolTip1.SetToolTip(txtMaDichVu, "Nhập mã dịch vụ (VD: DV001).");
            toolTip1.SetToolTip(txtTenDichVu, "Nhập tên dịch vụ (VD: Khám tổng quát).");
            toolTip1.SetToolTip(txtDonGia, "Nhập đơn giá dịch vụ (chỉ số, VD: 200000).");
            toolTip1.SetToolTip(txtTimKiem, "Nhập từ khóa để tìm kiếm (VD: DV001 hoặc Khám).");
        }

        DataClasses2DataContext db = new DataClasses2DataContext();

        private void LoadData()
        {
            var dichVus = from dv in db.DichVus
                          select new
                          {
                              dv.MaDichVu,
                              dv.TenDichVu,
                              dv.DonGia
                          };
            dgvDichVu.DataSource = dichVus.ToList();
            lblSoLuongDichVu.Text = $"Số lượng dịch vụ: {dichVus.Count()}";
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            LoadData();


            dgvDichVu.Columns[1].Width = 750;
            dgvDichVu.Columns[2].Width = 200;
            dgvDichVu.Columns[0].HeaderText = "Mã dịch vụ";
            dgvDichVu.Columns[1].HeaderText = "Tên dịch vụ";
            dgvDichVu.Columns[2].HeaderText = "Đơn giá";
            dgvDichVu.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Times New Roman", 10, FontStyle.Bold);
            dgvDichVu.DefaultCellStyle.BackColor = Color.White;
            dgvDichVu.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.Trim();
            var result = from dv in db.DichVus
                         where dv.TenDichVu.Contains(keyword) || dv.MaDichVu.Contains(keyword)
                         select new
                         {
                             dv.MaDichVu,
                             dv.TenDichVu,
                             dv.DonGia
                         };
            dgvDichVu.DataSource = result.ToList();
            if (!result.Any())
            {
                MessageBox.Show("Không tìm thấy dịch vụ nào phù hợp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            Excel.Application excelApp = new Excel.Application();
            if (excelApp == null)
            {
                MessageBox.Show("Excel không được cài đặt trên máy này.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Excel.Workbook workBook = excelApp.Workbooks.Add();
            Excel.Worksheet workSheet = (Excel.Worksheet)workBook.Sheets[1];
            workSheet.Name = "Danh sách Dịch Vụ"; 
            for (int i = 0; i < dgvDichVu.Columns.Count; i++)
            {
                workSheet.Cells[1, i + 1] = dgvDichVu.Columns[i].HeaderText; 
            }
            for (int i = 0; i < dgvDichVu.Rows.Count; i++)
            {
                for (int j = 0; j < dgvDichVu.Columns.Count; j++)
                {
                    workSheet.Cells[i + 2, j + 1] = dgvDichVu.Rows[i].Cells[j].Value?.ToString() ?? ""; 
                }
            }

            excelApp.Visible = true;
            Marshal.ReleaseComObject(workSheet);
            Marshal.ReleaseComObject(workBook);
            Marshal.ReleaseComObject(excelApp);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string maDichVu = txtMaDichVu.Text.Trim();
                string tenDichVu = txtTenDichVu.Text.Trim();
                decimal donGia = 0;
                if (string.IsNullOrEmpty(maDichVu) || string.IsNullOrEmpty(tenDichVu) || !decimal.TryParse(txtDonGia.Text.Trim(), out donGia))
                {
                    MessageBox.Show("Vui lòng kiểm tra lại giá trị nhập vào (Mã, Tên, Đơn giá).", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var dichVu = db.DichVus.FirstOrDefault(dv => dv.MaDichVu == maDichVu);
                if (dichVu != null)
                {
                    dichVu.TenDichVu = tenDichVu;
                    dichVu.DonGia = donGia;
                    db.SubmitChanges();
                    MessageBox.Show("Cập nhật dịch vụ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData(); 
                }
                else
                {
                    MessageBox.Show("Không tìm thấy dịch vụ cần sửa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {               
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvDichVu.SelectedRows.Count > 0)
                {
                    string maDichVu = dgvDichVu.SelectedRows[0].Cells["MaDichVu"].Value.ToString();
                    var dichVu = db.DichVus.FirstOrDefault(dv => dv.MaDichVu == maDichVu);

                    if (dichVu != null)
                    {
                        DialogResult dialogResult = MessageBox.Show($"Bạn có chắc chắn muốn xóa dịch vụ: {dichVu.TenDichVu} không?",
                                                                    "Xác nhận xóa",
                                                                    MessageBoxButtons.YesNo,
                                                                    MessageBoxIcon.Warning);
                        if (dialogResult == DialogResult.Yes)
                        {
                            db.DichVus.DeleteOnSubmit(dichVu);
                            db.SubmitChanges();
                            MessageBox.Show("Xóa dịch vụ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadData();

                        }
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy dịch vụ để xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một dịch vụ cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string maDichVu = txtMaDichVu.Text.Trim();
                string tenDichVu = txtTenDichVu.Text.Trim();
                decimal donGia = 0;

                if (string.IsNullOrEmpty(maDichVu) || string.IsNullOrEmpty(tenDichVu) || !decimal.TryParse(txtDonGia.Text.Trim(), out donGia))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin dịch vụ (Mã, Tên, Đơn giá).", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!maDichVu.StartsWith("DV"))
                {
                    MessageBox.Show("Mã dịch vụ phải bắt đầu bằng 'DV'. Vui lòng kiểm tra lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (donGia < 0)
                {
                    MessageBox.Show("Đơn giá không được phép là số âm. Vui lòng kiểm tra lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var existingDichVu = db.DichVus.FirstOrDefault(dv => dv.MaDichVu == maDichVu);
                if (existingDichVu != null)
                {
                    MessageBox.Show("Mã dịch vụ đã tồn tại trong hệ thống. Vui lòng nhập mã dịch vụ khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DichVu newDichVu = new DichVu
                {
                    MaDichVu = maDichVu,
                    TenDichVu = tenDichVu,
                    DonGia = donGia
                };

                db.DichVus.InsertOnSubmit(newDichVu);
                db.SubmitChanges();

                MessageBox.Show("Thêm dịch vụ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                txtMaDichVu.Clear();
                txtTenDichVu.Clear();
                txtDonGia.Clear();
                txtMaDichVu.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvDichVu_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                
                txtMaDichVu.Text = dgvDichVu.Rows[e.RowIndex].Cells["MaDichVu"].Value.ToString();
                txtTenDichVu.Text = dgvDichVu.Rows[e.RowIndex].Cells["TenDichVu"].Value.ToString();
                txtDonGia.Text = dgvDichVu.Rows[e.RowIndex].Cells["DonGia"].Value.ToString();

            }
        }

        private void btnIn1_Click(object sender, EventArgs e)
        {
            Excel.Application excelApp = new Excel.Application();
            if (excelApp == null)
            {
                MessageBox.Show("Excel không được cài đặt trên máy này.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Excel.Workbook workBook = excelApp.Workbooks.Add();
            Excel.Worksheet workSheet = (Excel.Worksheet)workBook.Sheets[1];
            workSheet.Name = "Danh sách Dịch Vụ"; 

            for (int i = 0; i < dgvDichVu.Columns.Count; i++)
            {
                workSheet.Cells[1, i + 1] = dgvDichVu.Columns[i].HeaderText; 
            }
            for (int i = 0; i < dgvDichVu.Rows.Count; i++)
            {
                for (int j = 0; j < dgvDichVu.Columns.Count; j++)
                {
                    workSheet.Cells[i + 2, j + 1] = dgvDichVu.Rows[i].Cells[j].Value?.ToString() ?? "";
                }
            }

            excelApp.Visible = true;

            Marshal.ReleaseComObject(workSheet);
            Marshal.ReleaseComObject(workBook);
            Marshal.ReleaseComObject(excelApp);
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtDonGia.Clear();
            txtTenDichVu.Clear();
            txtMaDichVu.Clear();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void txtTimKiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                Tim();
            }
        }

        private void Tim()
        {
            string keyword = txtTimKiem.Text.Trim();
            if (!string.IsNullOrEmpty(keyword))
            {
                MessageBox.Show($"Tìm kiếm với từ khóa: {keyword}", "Thông báo");
            }
            else
            {
                MessageBox.Show("Vui lòng nhập từ khóa.", "Cảnh báo");
            }
        }
    }
}
    


    

