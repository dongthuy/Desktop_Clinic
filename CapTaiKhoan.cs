using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Clinix
{
    public partial class CapTaiKhoan : Form
    {
        DataClasses2DataContext db = new DataClasses2DataContext();
        public CapTaiKhoan()
        {
            InitializeComponent();

            toolTip1.SetToolTip(txtMaTaiKhoan, "Mã tài khoản ( Xem từ danh sách tài khoản)");
            toolTip1.SetToolTip(txtMaNguoiDung, "Nhập mã người dùng tương ứng (xem từ danh sách nhân viên).");
            toolTip1.SetToolTip(txtTenDangNhap, "Nhập tên đăng nhập của tài khoản (VD: admin, user).");
            toolTip1.SetToolTip(txtMatKhau, "Nhập mật khẩu.");
            toolTip1.SetToolTip(txtXacNhanMatKhau, "Nhập lại mật khẩu để xác nhận.");
        }

        private void LoadData()
        {
            var taiKhoans = from tk in db.TaiKhoans
                            join nd in db.NguoiDungs
                            on tk.MaNguoiDung equals nd.MaNguoiDung
                            select new
                            {
                                tk.MaTaiKhoan,
                                tk.MaNguoiDung,
                                tk.TenTaiKhoan,
                                tk.MatKhau,
                                nd.LoaiNguoiDung,                                
                                NgayCapTaiKhoan = DateTime.Now 
                            };        
            dgvTaiKhoan.DataSource = taiKhoans.ToList();           
        }
      
        private void Form1_Load(object sender, EventArgs e)
        {
           
            LoadData();
            SinhMaTaiKhoanTiepTheo();
            dgvTaiKhoan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvTaiKhoan.Columns[0].HeaderText = "Mã Tài Khoản";
            dgvTaiKhoan.Columns[1].HeaderText = "Mã Người Dùng";
            dgvTaiKhoan.Columns[2].HeaderText = "Tên Tài Khoản";
            dgvTaiKhoan.Columns[3].HeaderText = "Mật Khẩu";
            dgvTaiKhoan.Columns[4].HeaderText = "Loại Người Dùng";
            dgvTaiKhoan.Columns[5].HeaderText = "Ngày Cấp Tài Khoản";

            dgvTaiKhoan.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;
            dgvTaiKhoan.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvTaiKhoan.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvTaiKhoan.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font(dgvTaiKhoan.Font, FontStyle.Bold);
            dgvTaiKhoan.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Times New Roman", 10, FontStyle.Bold); 
        }

        private void SinhMaTaiKhoanTiepTheo()
        {
            try
            {
                string maLonNhat = dgvTaiKhoan.Rows
                                    .Cast<DataGridViewRow>()
                                    .Select(hang => hang.Cells["MaTaiKhoan"].Value?.ToString())
                                    .Where(ma => !string.IsNullOrEmpty(ma))
                                    .OrderByDescending(ma => ma)
                                    .FirstOrDefault();

                if (string.IsNullOrEmpty(maLonNhat))
                {
                    txtMaTaiKhoan.Text = "TK1";
                    return;
                }
                int soHienTai = int.Parse(maLonNhat.Substring(2));
                string maMoi = "TK" + (soHienTai + 1);
                txtMaTaiKhoan.Text = maMoi;

                txtMaTaiKhoan.ReadOnly = true;
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show("Lỗi khi sinh mã tài khoản: " + ex.Message, "Thông báo",  MessageBoxIcon.Error);
            }
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if  (
                 string.IsNullOrEmpty(txtMaTaiKhoan.Text) ||
                 string.IsNullOrEmpty(txtTenDangNhap.Text) ||
                 string.IsNullOrEmpty(txtMatKhau.Text) ||
                 string.IsNullOrEmpty(txtXacNhanMatKhau.Text) ||
                 string.IsNullOrEmpty(txtMaNguoiDung.Text)
                )
            {
                CustomMessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo", MessageBoxIcon.Warning);
                return;
            }

            if (txtMatKhau.Text != txtXacNhanMatKhau.Text)
            {
                CustomMessageBox.Show("Mật khẩu và xác nhận mật khẩu không khớp.", "Thông báo", MessageBoxIcon.Warning);
                return;
            }
            foreach (DataGridViewRow row in dgvTaiKhoan.Rows)
            {
                if (row.Cells["MaNguoiDung"].Value != null && row.Cells["MaNguoiDung"].Value.ToString() == txtMaNguoiDung.Text.Trim())
                {
                    CustomMessageBox.Show("Mã người dùng đã tồn tại trong danh sách tài khoản. ", "Thông báo", MessageBoxIcon.Warning);
                    return;
                }
            }

            var nguoiDung = db.NguoiDungs.FirstOrDefault(nd => nd.MaNguoiDung == txtMaNguoiDung.Text.Trim());
            if (nguoiDung != null && nguoiDung.LoaiNguoiDung == "Y tá")
            {
                CustomMessageBox.Show("Không thể tạo tài khoản cho người dùng có loại là Y tá.", "Thông báo", MessageBoxIcon.Warning);
                return;
            }

            var existingTaiKhoan = db.TaiKhoans.FirstOrDefault(tk => tk.MaTaiKhoan == txtMaTaiKhoan.Text.Trim());
            if (existingTaiKhoan != null)
            {
                CustomMessageBox.Show("Mã tài khoản đã tồn tại. Vui lòng chọn mã khác.", "Thông báo", MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var taiKhoanMoi = new TaiKhoan
                {
                    MaTaiKhoan = txtMaTaiKhoan.Text,
                    TenTaiKhoan = txtTenDangNhap.Text,
                    MatKhau = txtMatKhau.Text,
                    MaNguoiDung = txtMaNguoiDung.Text,
                };

                db.TaiKhoans.InsertOnSubmit(taiKhoanMoi);
                db.SubmitChanges();

                CustomMessageBox.Show("Tạo tài khoản thành công.", "Thông báo", MessageBoxIcon.Information);

                LoadData();
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show("Lỗi khi tạo tài khoản: " + ex.Message, "Thông báo", MessageBoxIcon.Error);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            SinhMaTaiKhoanTiepTheo();

            txtMatKhau.Clear();
            txtXacNhanMatKhau.Clear();
            txtMaNguoiDung.Clear();
            txtTenDangNhap.Clear();
            txtMaNguoiDung.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvTaiKhoan.SelectedRows.Count > 0)
            {
                string maTaiKhoan = dgvTaiKhoan.SelectedRows[0].Cells["MaTaiKhoan"].Value.ToString();

                using (var db = new DataClasses2DataContext())
                {
                    var taiKhoanToDelete = db.TaiKhoans.SingleOrDefault(tk => tk.MaTaiKhoan == maTaiKhoan);

                    if (taiKhoanToDelete != null)
                    {
                        db.TaiKhoans.DeleteOnSubmit(taiKhoanToDelete);
                        db.SubmitChanges(); 
                    }
                    else
                    {
                        CustomMessageBox.Show("Tài khoản không tồn tại.");
                    }
                }

                LoadData(); 
            }
            else
            {
                CustomMessageBox.Show("Vui lòng chọn tài khoản cần xóa.");

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvTaiKhoan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
                DataGridViewRow row = dgvTaiKhoan.Rows[e.RowIndex];
                txtMaTaiKhoan.Text = row.Cells["MaTaiKhoan"].Value.ToString();
                txtMaNguoiDung.Text = row.Cells["MaNguoiDung"].Value.ToString();
                txtTenDangNhap.Text = row.Cells["TenTaiKhoan"].Value.ToString();
                txtMatKhau.Text = row.Cells["MatKhau"].Value.ToString();
                txtXacNhanMatKhau.Text = row.Cells["MatKhau"].Value.ToString(); // Hiển thị lại mật khẩu
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (
                string.IsNullOrEmpty(txtMaTaiKhoan.Text) ||
                string.IsNullOrEmpty(txtTenDangNhap.Text) ||
                string.IsNullOrEmpty(txtMatKhau.Text) ||
                string.IsNullOrEmpty(txtXacNhanMatKhau.Text) ||
                string.IsNullOrEmpty(txtMaNguoiDung.Text))
            {
                CustomMessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo",  MessageBoxIcon.Warning);
                return;
            }

            if (txtMatKhau.Text != txtXacNhanMatKhau.Text)
            {
                CustomMessageBox.Show("Mật khẩu và xác nhận mật khẩu không khớp.", "Thông báo",  MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var taiKhoan = db.TaiKhoans.SingleOrDefault(tk => tk.MaTaiKhoan == txtMaTaiKhoan.Text.Trim());

                if (taiKhoan != null)
                {
                    taiKhoan.TenTaiKhoan = txtTenDangNhap.Text.Trim();
                    taiKhoan.MatKhau = txtMatKhau.Text.Trim();
                    taiKhoan.MaNguoiDung = txtMaNguoiDung.Text.Trim();
                    db.SubmitChanges();

                    CustomMessageBox.Show("Cập nhật tài khoản thành công.", "Thông báo",  MessageBoxIcon.Information);
                    LoadData();
                }
                else
                {
                    CustomMessageBox.Show("Không tìm thấy tài khoản để cập nhật.", "Thông báo", MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show("Lỗi khi cập nhật tài khoản: " + ex.Message, "Thông báo", MessageBoxIcon.Error);
            }
        }

        private void dgvTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvTaiKhoan.Rows[e.RowIndex];
                txtMaTaiKhoan.Text = row.Cells["MaTaiKhoan"].Value.ToString();
                txtMaNguoiDung.Text = row.Cells["MaNguoiDung"].Value.ToString();
                txtTenDangNhap.Text = row.Cells["TenTaiKhoan"].Value.ToString();
                txtMatKhau.Text = row.Cells["MatKhau"].Value.ToString();
                txtXacNhanMatKhau.Text = row.Cells["MatKhau"].Value.ToString(); 
            }
        }
    }
}
    

