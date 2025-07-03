using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using Excel = Microsoft.Office.Interop.Excel;
using Clinix;

namespace CLinix
{
    public partial class frmDanhSach : Form
    {
        public frmDanhSach()
        {
            InitializeComponent();
        }       

        private void btnThemfrmDS_Click(object sender, EventArgs e)
        {
            var frmThem = new frmThem(this);
            frmThem.Show();
        }
        private void btnXemChiTiet_Click(object sender, EventArgs e)
        {           
            if (!string.IsNullOrEmpty(txtMaNDfrmDS.Text))
            {
                var frmXemChiTiet = new frmXemChiTiet(txtMaNDfrmDS.Text, this);
                frmXemChiTiet.Show();
            }
            else
            {
                CustomMessageBox.Show("Vui lòng chọn nhân viên.", "Thông báo", MessageBoxIcon.Warning);
            }
            
        }

        private bool isUpdatingComboBox = false;
        private void frmDanhSach_Load(object sender, EventArgs e)
        {
            txtMaNDfrmDS.Enabled = false;
            txtHoTenfrmDS.Enabled = false;

            LoadLoaiNguoiDung();
            cbLoaiNguoiDungfrmDS.SelectedIndex = -1;

            LoadNguoiDung();

            dgvDanhSachNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvDanhSachNhanVien.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDanhSachNhanVien.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;
            dgvDanhSachNhanVien.ColumnHeadersDefaultCellStyle.Font = new Font(dgvDanhSachNhanVien.Font, FontStyle.Bold);

            foreach (DataGridViewColumn column in dgvDanhSachNhanVien.Columns)
            {
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            dgvDanhSachNhanVien.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;
        }
        

        public void LoadNguoiDung(string loaiNguoiDung = null)
        {
            cbLoaiNguoiDungfrmDS.Height = 25;
           DataClasses2DataContext db = new DataClasses2DataContext();

            db.Connection.Open();

            var taiLen = from nd in db.NguoiDungs
                         select new
                         {
                             MaNguoiDung = nd.MaNguoiDung,
                             HoTen = nd.HoTen,
                             ChucVu = nd.LoaiNguoiDung,
                         };

            if ((!string.IsNullOrEmpty(loaiNguoiDung)))
            {
                taiLen = taiLen.Where(nd => nd.ChucVu == loaiNguoiDung);
            }

            dgvDanhSachNhanVien.DataSource = taiLen.ToList();

            dgvDanhSachNhanVien.Columns["MaNguoiDung"].Width = 100;
            dgvDanhSachNhanVien.Columns["HoTen"].Width = 250;
            dgvDanhSachNhanVien.Columns["ChucVu"].Width = 150;

            dgvDanhSachNhanVien.Columns["MaNguoiDung"].HeaderText = "Mã người dùng";
            dgvDanhSachNhanVien.Columns["HoTen"].HeaderText = "Họ và tên";
            dgvDanhSachNhanVien.Columns["ChucVu"].HeaderText = "Chức vụ";

            db.Connection.Close();
        }

        private void LoadLoaiNguoiDung()
        {
             DataClasses2DataContext db = new DataClasses2DataContext();

            db.Connection.Open();

            var loaiNguoiDungList = db.NguoiDungs
                    .Select(nd => nd.LoaiNguoiDung).Distinct().ToList();

            loaiNguoiDungList.Insert(0, "");

            cbLoaiNguoiDungfrmDS.DataSource = loaiNguoiDungList;

            db.Connection.Close();
        }

        private void cbLoaiNguoiDungfrmDS_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isUpdatingComboBox) return; // Bỏ qua nếu đang cập nhật từ DataGridView

            if (cbLoaiNguoiDungfrmDS.SelectedItem == null) return;

            string selectedLoai = cbLoaiNguoiDungfrmDS.SelectedItem.ToString();

            if (string.IsNullOrEmpty(selectedLoai))
            {
                LoadNguoiDung(); // Lọc tất cả người dùng
            }
            else
            {
                LoadNguoiDung(selectedLoai); // Lọc theo chức vụ đã chọn
            }

        }

        private void dgvDanhSachNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaNDfrmDS.ReadOnly = true;
            int i;
            i = dgvDanhSachNhanVien.CurrentRow.Index;
            txtMaNDfrmDS.Text = dgvDanhSachNhanVien.Rows[i].Cells[0].Value.ToString();
            txtHoTenfrmDS.Text = dgvDanhSachNhanVien.Rows[i].Cells[1].Value.ToString();

            isUpdatingComboBox = true;
            cbLoaiNguoiDungfrmDS.Text = dgvDanhSachNhanVien.Rows[i].Cells[2].Value.ToString();
            isUpdatingComboBox = false;
        }

        private void btnXoafrmDS_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaNDfrmDS.Text))
            {
                CustomMessageBox.Show("Vui lòng chọn nhân viên cần xóa.", "Thông báo", MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = CustomMessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này?", "Xác nhận", MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                try  
                {
                     DataClasses2DataContext db = new DataClasses2DataContext();
                    db.Connection.Open();

                    var transaction = db.Connection.BeginTransaction();
                    db.Transaction = transaction;

                    try
                    {
                        var thongTinBS = from bs in db.BacSis
                                           where bs.MaNguoiDung == txtMaNDfrmDS.Text.Trim()
                                           select bs;
                        db.BacSis.DeleteAllOnSubmit(thongTinBS);

                        var thongTinLT = from lt in db.LeTans
                                           where lt.MaNguoiDung == txtMaNDfrmDS.Text.Trim()
                                           select lt;
                        db.LeTans.DeleteAllOnSubmit(thongTinLT);

                        var thongTinQL = from ql in db.QuanLies
                                            where ql.MaNguoiDung == txtMaNDfrmDS.Text.Trim()
                                            select ql;
                        db.QuanLies.DeleteAllOnSubmit(thongTinQL);

                        NguoiDung nd = (from nguoidung in db.NguoiDungs
                                        where nguoidung.MaNguoiDung == txtMaNDfrmDS.Text.Trim()
                                        select nguoidung).SingleOrDefault();

                        if (nd != null)
                        {
                            db.NguoiDungs.DeleteOnSubmit(nd);
                        }

                        db.SubmitChanges();
                        transaction.Commit();//Lưu

                        LoadNguoiDung();

                        CustomMessageBox.Show("Đã xóa thành công.", "Thông báo", MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        CustomMessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxIcon.Error);
                    }
                    finally
                    {
                        db.Connection.Close();
                    }
                }
                catch (Exception ex)
                {
                    CustomMessageBox.Show("Không thể kết nối: " + ex.Message, "Lỗi", MessageBoxIcon.Error);
                }
            }
        }
    


        private void btnDongfrmDS_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTimfrmDS_Click(object sender, EventArgs e)
        {
             DataClasses2DataContext db = new DataClasses2DataContext();
            db.Connection.Open();

            string chucVuSelected = cbLoaiNguoiDungfrmDS.SelectedItem?.ToString();


            var TimKiem = from nv in db.NguoiDungs
                          where (string.IsNullOrEmpty(txtTimfrmDS.Text) || nv.HoTen.Contains(txtTimfrmDS.Text)) 
                             && (string.IsNullOrEmpty(chucVuSelected) || nv.LoaiNguoiDung == chucVuSelected)
                          select new
                          {
                              MaNguoiDung = nv.MaNguoiDung,
                              HoTen = nv.HoTen,
                              ChucVu = nv.LoaiNguoiDung,
                          };
            var kq = TimKiem.ToList();
            if (kq.Count == 0)
            {
                CustomMessageBox.Show("Không tìm thất kết quả phù hợp.", "Thông báo");
            }   
            else
            {
                dgvDanhSachNhanVien.DataSource = TimKiem.ToList();
            }
            db.Connection.Close();
        }

        private void XuatFileDanhSach(string duongDan)
        {
            Excel.Application app = new Excel.Application();
            app.Application.Workbooks.Add(Type.Missing);

            try
            {
                // Mở kết nối LINQ
                 DataClasses2DataContext db = new DataClasses2DataContext();
                db.Connection.Open();

                var nguoiDungList = from nd in db.NguoiDungs
                                    select nd;

                // Ghi tiêu đề cột (lấy theo thuộc tính của bảng NguoiDungs)
                app.Cells[1, 1] = "Mã người dùng";
                app.Cells[1, 2] = "Họ và tên";
                app.Cells[1, 3] = "Giới tính";
                app.Cells[1, 4] = "Ngày sinh"; // Nếu có thêm cột trong bảng
                app.Cells[1, 5] = "SĐT";     // Ví dụ thêm cột Email
                app.Cells[1, 6] = "Địa chỉ";
                app.Cells[1, 7] = "Chức vụ";

                // Ghi dữ liệu từng dòng vào Excel
                int row = 2; // Bắt đầu từ dòng thứ 2
                foreach (var nd in nguoiDungList)
                {
                    app.Cells[row, 1] = nd.MaNguoiDung;
                    app.Cells[row, 2] = nd.HoTen;
                    app.Cells[row, 3] = nd.GioiTinh;
                    app.Cells[row, 4] = nd.NgaySinh;  // Ghi thêm cột ngày sinh nếu có
                    app.Cells[row, 5] = nd.SDT;
                    app.Cells[row, 6] = nd.DiaChi;
                    app.Cells[row, 7] = nd.LoaiNguoiDung;
                    row++;
                }

                app.Columns.AutoFit();

                app.ActiveWorkbook.SaveCopyAs(duongDan);
                app.ActiveWorkbook.Saved = true;

                CustomMessageBox.Show("Xuất file thành công!", "Thông báo", MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show("Xuất file không thành công!\n" + ex.Message, "Lỗi", MessageBoxIcon.Error);
            }
        }

        private void btnXuatfrmDS_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog
            {
                Title = "Xuất danh sách nhân viên",
                Filter = "Excel (*.xlsx)|*.xlsx"
            };

            if (save.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    XuatFileDanhSach(save.FileName);
                }
                catch (Exception ex)
                {
                    CustomMessageBox.Show("Lỗi khi xuất file: " + ex.Message, "Lỗi", MessageBoxIcon.Error);
                }
            }
        }

    }
        
}

        

   

