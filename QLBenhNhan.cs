using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using OfficeOpenXml;
using System.IO;
using OfficeOpenXml.Style;
using System.Diagnostics;

namespace Clinix
{
    public partial class frmQLBenhNhan : Form
    {
        DataClasses2DataContext da = new DataClasses2DataContext();

        public frmQLBenhNhan()
        {
            InitializeComponent();
            EnableControls(false);
        }

        private void frmQLBenhNhan_Load(object sender, EventArgs e)
        {
            btnLamMoi_Click(sender, e);
            EnableControls(false);
        }

        private void EnableControls(bool isEnabled)
        {
            txtHoTen.Enabled = isEnabled;
            txtDiaChi.Enabled = isEnabled;
            txtSDT.Enabled = isEnabled;
            radNam.Enabled = isEnabled;
            radNu.Enabled = isEnabled;
            dtpNgaySinh.Enabled = isEnabled;
            btnLuu.Enabled = isEnabled;

            if (isEnabled)
            {
                txtMaBN.Enabled = true;
            }
            else
            {
                txtMaBN.Enabled = false;
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            var listBenhNhan = from bn in da.BenhNhans
                               select new
                               {
                                   bn.MaBenhNhan,
                                   bn.TenBenhNhan,
                                   bn.NgaySinh,
                                   bn.GioiTinh,
                                   bn.DiaChi,
                                   bn.SDT
                               };
            dgvDanhSachBN.DataSource = listBenhNhan;

            dgvDanhSachBN.Columns[0].HeaderText = "Mã bệnh nhân";
            dgvDanhSachBN.Columns[1].HeaderText = "Tên bệnh nhân";
            dgvDanhSachBN.Columns[2].HeaderText = "Ngày sinh";
            dgvDanhSachBN.Columns[3].HeaderText = "Giới tính";
            dgvDanhSachBN.Columns[4].HeaderText = "Địa chỉ";
            dgvDanhSachBN.Columns[5].HeaderText = "Số điện thoại";

            dgvDanhSachBN.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDanhSachBN.Columns[0].Width = 120;
            dgvDanhSachBN.Columns[1].Width = 150;
            dgvDanhSachBN.Columns[2].Width = 100;
            dgvDanhSachBN.Columns[3].Width = 80;
            dgvDanhSachBN.Columns[4].Width = 200;
            dgvDanhSachBN.Columns[5].Width = 120;

            dgvDanhSachBN.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvDanhSachBN.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;

            foreach (DataGridViewColumn column in dgvDanhSachBN.Columns)
            {
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            }

            dgvDanhSachBN.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;

            dgvDanhSachBN.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvDanhSachBN.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            txtMaBN.Clear();
            txtHoTen.Clear();
            txtDiaChi.Clear();
            txtSDT.Clear();
            txtTimKiem.Clear();
            radNam.Checked = false;
            radNu.Checked = false;
            dtpNgaySinh.CustomFormat = " ";
            dtpNgaySinh.Format = DateTimePickerFormat.Custom;
            dtpNgaySinh.Value = DateTime.Now;

            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;

            EnableControls(false);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            EnableControls(true);
            txtMaBN.Clear();
            txtHoTen.Clear();
            txtDiaChi.Clear();
            txtSDT.Clear();
            radNam.Checked = false;
            radNu.Checked = false;
            dtpNgaySinh.Format = DateTimePickerFormat.Short;
            dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            dtpNgaySinh.Value = DateTime.Now;
            txtMaBN.Focus();

            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
        }

        private void txtHoTen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaBN.Text) || string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maBN = txtMaBN.Text.Trim();
            var benhNhanTonTai = da.BenhNhans.SingleOrDefault(bnCheck => bnCheck.MaBenhNhan == maBN);

            if (benhNhanTonTai != null)
            {
                MessageBox.Show("Mã bệnh nhân đã tồn tại! Vui lòng nhập mã khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaBN.Focus();
                return;
            }

            BenhNhan bn = new BenhNhan
            {
                MaBenhNhan = maBN,
                TenBenhNhan = txtHoTen.Text.Trim(),
                NgaySinh = dtpNgaySinh.Value,
                GioiTinh = radNam.Checked ? "Nam" : "Nữ",
                DiaChi = txtDiaChi.Text.Trim(),
                SDT = txtSDT.Text.Trim()
            };

            da.BenhNhans.InsertOnSubmit(bn);
            da.SubmitChanges();

            MessageBox.Show("Thêm bệnh nhân thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            btnLamMoi_Click(sender, e);

            foreach (DataGridViewRow row in dgvDanhSachBN.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == bn.MaBenhNhan)
                {
                    row.Selected = true;
                    dgvDanhSachBN.FirstDisplayedScrollingRowIndex = row.Index; // Cuộn đến dòng đó
                    break;
                }
            }

            btnThem.Enabled = true;
            btnLuu.Enabled = false;
            EnableControls(false);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvDanhSachBN.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn bệnh nhân cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maBN = dgvDanhSachBN.SelectedRows[0].Cells[0].Value.ToString();

            var benhNhanCanXoa = da.BenhNhans.SingleOrDefault(bn => bn.MaBenhNhan == maBN);

            if (benhNhanCanXoa != null)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa bệnh nhân này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    da.BenhNhans.DeleteOnSubmit(benhNhanCanXoa);
                    da.SubmitChanges();

                    MessageBox.Show("Xóa bệnh nhân thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    btnLamMoi_Click(sender, e);
                }
            }
            else
            {
                MessageBox.Show("Bệnh nhân không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvDanhSachBN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string maBN = dgvDanhSachBN.Rows[e.RowIndex].Cells[0].Value.ToString();
                string tenBN = dgvDanhSachBN.Rows[e.RowIndex].Cells[1].Value.ToString();
                DateTime ngaySinh = Convert.ToDateTime(dgvDanhSachBN.Rows[e.RowIndex].Cells[2].Value);
                string gioiTinh = dgvDanhSachBN.Rows[e.RowIndex].Cells[3].Value.ToString();
                string diaChi = dgvDanhSachBN.Rows[e.RowIndex].Cells[4].Value.ToString();
                string sdt = dgvDanhSachBN.Rows[e.RowIndex].Cells[5].Value.ToString();

                txtMaBN.Text = maBN;
                txtHoTen.Text = tenBN;
                dtpNgaySinh.Format = DateTimePickerFormat.Short;
                dtpNgaySinh.Value = ngaySinh;
                txtDiaChi.Text = diaChi;
                txtSDT.Text = sdt;

                if (gioiTinh == "Nam")
                {
                    radNam.Checked = true;
                    radNu.Checked = false;
                }
                else
                {
                    radNam.Checked = false;
                    radNu.Checked = true;
                }

                EnableControls(true);
                btnLuu.Enabled = false;
                btnThem.Enabled = false;
            }

            txtMaBN.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaBN.Text))
            {
                MessageBox.Show("Vui lòng chọn bệnh nhân cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            EnableControls(true);
            txtMaBN.Enabled = false;

            string maBN = txtMaBN.Text.Trim();
            var benhNhanCanSua = da.BenhNhans.SingleOrDefault(bn => bn.MaBenhNhan == maBN);

            if (benhNhanCanSua != null)
            {
                benhNhanCanSua.TenBenhNhan = txtHoTen.Text.Trim();
                benhNhanCanSua.NgaySinh = dtpNgaySinh.Value;
                benhNhanCanSua.GioiTinh = radNam.Checked ? "Nam" : "Nữ";
                benhNhanCanSua.DiaChi = txtDiaChi.Text.Trim();
                benhNhanCanSua.SDT = txtSDT.Text.Trim();

                da.SubmitChanges();

                MessageBox.Show("Cập nhật thông tin bệnh nhân thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                btnLamMoi_Click(sender, e);

                foreach (DataGridViewRow row in dgvDanhSachBN.Rows)
                {
                    if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == maBN)
                    {
                        row.Selected = true;
                        dgvDanhSachBN.FirstDisplayedScrollingRowIndex = row.Index;
                        break;
                    }
                }
            }
            else
            {
                MessageBox.Show("Bệnh nhân không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            EnableControls(false);
            btnLuu.Enabled = false;
            btnThem.Enabled = true;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string searchTerm = txtTimKiem.Text.Trim();

            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                MessageBox.Show("Vui lòng nhập mã bệnh nhân hoặc tên bệnh nhân để tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var searchResults = from bn in da.BenhNhans
                                where bn.MaBenhNhan.Contains(searchTerm) || bn.TenBenhNhan.Contains(searchTerm)
                                select new
                                {
                                    bn.MaBenhNhan,
                                    bn.TenBenhNhan,
                                    bn.NgaySinh,
                                    bn.GioiTinh,
                                    bn.DiaChi,
                                    bn.SDT
                                };

            if (!searchResults.Any())
            {
                MessageBox.Show("Không tìm thấy bệnh nhân nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                btnLamMoi_Click(sender, e);
            }
            else
            {
                dgvDanhSachBN.DataSource = searchResults.ToList();
            }
        }

        private void btnXuatE_Click(object sender, EventArgs e)
        {
            if (dgvDanhSachBN.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Excel Files|*.xlsx";
                sfd.Title = "Lưu file Excel";
                sfd.FileName = "DanhSachBenhNhan.xlsx";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (ExcelPackage package = new ExcelPackage())
                        {
                            ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Danh sách bệnh nhân");

                            for (int i = 0; i < dgvDanhSachBN.Columns.Count; i++)
                            {
                                worksheet.Cells[1, i + 1].Value = dgvDanhSachBN.Columns[i].HeaderText;
                                worksheet.Cells[1, i + 1].Style.Font.Bold = true;
                                worksheet.Cells[1, i + 1].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

                                worksheet.Cells[1, i + 1].Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                                worksheet.Cells[1, i + 1].Style.Fill.BackgroundColor.SetColor(Color.LightBlue);
                            }

                            for (int i = 0; i < dgvDanhSachBN.Rows.Count; i++)
                            {
                                for (int j = 0; j < dgvDanhSachBN.Columns.Count; j++)
                                {
                                    var cellValue = dgvDanhSachBN.Rows[i].Cells[j].Value;

                                    if (dgvDanhSachBN.Columns[j].HeaderText == "Ngày sinh")
                                    {
                                        if (cellValue is DateTime dateValue)
                                        {
                                            worksheet.Cells[i + 2, j + 1].Value = dateValue;
                                            worksheet.Cells[i + 2, j + 1].Style.Numberformat.Format = "dd/MM/yyyy";
                                        }
                                        else if (cellValue != null)
                                        {
                                            if (DateTime.TryParse(cellValue.ToString(), out DateTime parsedDate))
                                            {
                                                worksheet.Cells[i + 2, j + 1].Value = parsedDate;
                                                worksheet.Cells[i + 2, j + 1].Style.Numberformat.Format = "dd/MM/yyyy";
                                            }
                                            else
                                            {
                                                worksheet.Cells[i + 2, j + 1].Value = cellValue?.ToString();
                                            }
                                        }
                                        else
                                        {
                                            worksheet.Cells[i + 2, j + 1].Value = cellValue?.ToString();
                                        }
                                    }
                                    else
                                    {
                                        worksheet.Cells[i + 2, j + 1].Value = cellValue?.ToString();
                                    }
                                }
                            }

                            worksheet.Cells[worksheet.Dimension.Address].AutoFitColumns();

                            FileInfo fileInfo = new FileInfo(sfd.FileName);
                            package.SaveAs(fileInfo);
                        }

                        MessageBox.Show("Xuất file Excel thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Process.Start(new ProcessStartInfo
                        {
                            FileName = sfd.FileName,
                            UseShellExecute = true
                        });
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Menu trangChu = new Menu();
            trangChu.Show();
        }
    }
}
