using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Clinix
{
    public partial class frmXemChiTiet : Form
    {
        private string _maND;
        private frmDanhSach _frmDanhSach;

        public frmXemChiTiet(string maND, frmDanhSach frmDS)
        {
            InitializeComponent();
            _maND = maND;
            _frmDanhSach = frmDS ?? throw new ArgumentNullException(nameof(frmDS), "Form danh sách không được null.");
        }

        private void LoadChucVu()
        {
            DataClasses2DataContext db = new DataClasses2DataContext();

            db.Connection.Open();

            var loaiNguoiDungList = db.NguoiDungs
            .Select(nd => nd.LoaiNguoiDung).Distinct().ToList();

            cbChucVufrmXem.DataSource = loaiNguoiDungList;

            var chucVuHienTai = (from nd in db.NguoiDungs
                                 where nd.MaNguoiDung == txtMaNDfrmXem.Text.Trim()
                                 select nd.LoaiNguoiDung).FirstOrDefault();

            if (chucVuHienTai != null)
            {
                cbChucVufrmXem.SelectedItem = chucVuHienTai;
            }

            db.Connection.Close();
        }
        private void LoadGioiTinh()
        {
            DataClasses2DataContext db = new DataClasses2DataContext();

            db.Connection.Open();

            var gioiTinhList = db.NguoiDungs.Select(nd => nd.GioiTinh).Distinct().ToList();
            cbGioiTinhfrmXem.DataSource = gioiTinhList;

            var gioiTinhNV = (from gt in db.NguoiDungs
                              where gt.MaNguoiDung == txtMaNDfrmXem.Text.Trim().ToString()
                              select gt.GioiTinh).Distinct().ToList();
            if (gioiTinhNV != null)
            {
                cbChucVufrmXem.SelectedItem = gioiTinhNV;
            }

            db.Connection.Close();
        }
        private string FormatPhoneNumber(string phoneNumber)
        {
            if (phoneNumber.Length == 10) 
            {
                return $"{phoneNumber.Substring(0, 3)} {phoneNumber.Substring(3, 3)} {phoneNumber.Substring(6)}";
            }
            else if (phoneNumber.Length == 11) 
            {
                return $"{phoneNumber.Substring(0, 4)} {phoneNumber.Substring(4, 3)} {phoneNumber.Substring(7)}";
            }

            return phoneNumber; 
        }
        private void frmXemChiTiet_Load(object sender, EventArgs e)
        {
            cbChucVufrmXem.Height = 25;
            cbGioiTinhfrmXem.Height = 25;
            dtpNgaySinhfrmXem.Height = 25;

            txtMaNDfrmXem.Enabled = false;
            txtMaNVfrmXem.Enabled = false;
            txtHoTenfrmXem.Enabled = false;
            txtDiaChifrmXem.Enabled = false;
            txtSDTfrmXem.Enabled = false;
            txtChuyenMonfrmXem.Enabled = false;
            cbChucVufrmXem.Enabled = false;            
            cbGioiTinhfrmXem.Enabled = false;           
            dtpNgaySinhfrmXem.Enabled = false;

            LoadChiTietNhanVien();
            LoadChucVu();
            LoadGioiTinh();
        }

        private void LoadChiTietNhanVien()
        {
            try
            {
                DataClasses2DataContext db = new DataClasses2DataContext();
                db.Connection.Open();

                var nguoiDung = (from nd in db.NguoiDungs
                                 where nd.MaNguoiDung == _maND
                                 select nd).SingleOrDefault();

                if (nguoiDung != null)
                {
                    txtMaNDfrmXem.Text = nguoiDung.MaNguoiDung;
                    txtHoTenfrmXem.Text = nguoiDung.HoTen;
                    txtDiaChifrmXem.Text = nguoiDung.DiaChi;
                    txtSDTfrmXem.Text = FormatPhoneNumber(nguoiDung.SDT);
                    dtpNgaySinhfrmXem.Value = nguoiDung.NgaySinh.Value;
                    cbChucVufrmXem.SelectedValue = nguoiDung.LoaiNguoiDung;
                    cbGioiTinhfrmXem.SelectedValue = nguoiDung.GioiTinh;

                    if (nguoiDung.BacSis.Any())
                    {
                        txtChuyenMonfrmXem.Text = string.Join(", ", nguoiDung.BacSis.Select(bs => bs.ChuyenMon));
                        txtMaNVfrmXem.Text = string.Join(", ", nguoiDung.BacSis.Select(bs => bs.MaBacSi));
                    }

                    else if (nguoiDung.LeTans.Any())
                    {
                        txtMaNVfrmXem.Text = string.Join(", ", nguoiDung.LeTans.Select(lt => lt.MaLeTan));
                    }
                    else if (nguoiDung.QuanLies != null)
                    {
                        txtMaNVfrmXem.Text = string.Join(", ", nguoiDung.QuanLies.Select(ql => ql.MaQuanLy));
                    }
                }
                else
                {
                    CustomMessageBox.Show("Không tìm thấy thông tin nhân viên.", "Thông báo", MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show("Đã xảy ra lỗi khi tải thông tin: " + ex.Message, "Lỗi", MessageBoxIcon.Error);
            }
        }

        private bool KiemTraSDT(string soDienThoai)
        {
            if (soDienThoai.Length != 10)
                return false;

            if (!soDienThoai.StartsWith("0"))
                return false;

            return soDienThoai.All(char.IsDigit);
        }

        private void btnDongfrmXem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCapNhatfrmXem_Click(object sender, EventArgs e)
        {
            txtHoTenfrmXem.Enabled = true;
            txtDiaChifrmXem.Enabled = true;
            txtSDTfrmXem.Enabled = true;
            cbGioiTinhfrmXem.Enabled = true;
            dtpNgaySinhfrmXem.Enabled = true;

            var chucVuHienTai = cbChucVufrmXem.SelectedItem?.ToString();

            if (chucVuHienTai != null && chucVuHienTai != "Bác sĩ")
            {
                txtChuyenMonfrmXem.Enabled = false;
            }
            else
            {
                txtChuyenMonfrmXem.Enabled = true;
            }
        }    

        private void btnLuufrmXem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHoTenfrmXem.Text))
            {
                CustomMessageBox.Show("Họ tên không được để trống.", "Thông báo", MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtDiaChifrmXem.Text))
            {
                CustomMessageBox.Show("Địa chỉ không được để trống.", "Thông báo", MessageBoxIcon.Warning);
                return;
            }

            string soDienThoai = txtSDTfrmXem.Text.Replace(" ", "").Trim();

            if (!KiemTraSDT(soDienThoai))
            {
                CustomMessageBox.Show("Số điện thoại không hợp lệ!\nVui lòng nhập lại!", "Thông báo", MessageBoxIcon.Error);
                return;
            }

            if (cbGioiTinhfrmXem.SelectedItem == null)
            {
                CustomMessageBox.Show("Vui lòng chọn giới tính.", "Thông báo", MessageBoxIcon.Warning);
                return;
            }

            if (cbChucVufrmXem.SelectedItem != null && cbChucVufrmXem.SelectedItem.ToString() == "Bác sĩ")
            {
                if (string.IsNullOrWhiteSpace(txtChuyenMonfrmXem.Text))
                {
                    CustomMessageBox.Show("Vui lòng nhập chuyên môn cho bác sĩ.", "Thông báo", MessageBoxIcon.Warning);
                    return;
                }
            }
                DialogResult result = CustomMessageBox.Show("Bạn có chắc chắn muốn thay đổi thông tin nhân viên?", "Thông báo", MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                try  
                {
                    DataClasses2DataContext db = new DataClasses2DataContext ();
                    db.Connection.Open();

                    var transaction = db.Connection.BeginTransaction();
                    db.Transaction = transaction;

                    try
                    {
                        var nd = db.NguoiDungs.SingleOrDefault(nguoiDung => nguoiDung.MaNguoiDung == _maND);
                        if (nd != null)
                        {
                            nd.HoTen = txtHoTenfrmXem.Text.Trim();
                            nd.DiaChi = txtDiaChifrmXem.Text.Trim();
                            nd.SDT = txtSDTfrmXem.Text.Trim();
                            nd.GioiTinh = cbGioiTinhfrmXem.SelectedItem?.ToString();
                            nd.NgaySinh = dtpNgaySinhfrmXem.Value;
                            nd.LoaiNguoiDung = cbChucVufrmXem.SelectedItem?.ToString();

                            switch (nd.LoaiNguoiDung)
                            {
                                case "Bác sĩ":
                                    var bacSiList = db.BacSis.Where(bs => bs.MaNguoiDung == nd.MaNguoiDung);
                                    if (bacSiList.Any())
                                    {
                                        foreach (var bacSi in bacSiList)
                                        {
                                            bacSi.ChuyenMon = txtChuyenMonfrmXem.Text.Trim();
                                        }
                                    }
                                    break;

                                case "Quản lý":
                                    if (!db.QuanLies.Any(ql => ql.MaNguoiDung == nd.MaNguoiDung))
                                    {
                                        db.QuanLies.InsertOnSubmit(new QuanLy
                                        {
                                            MaNguoiDung = nd.MaNguoiDung
                                        });
                                    }
                                    break;

                                case "Lễ tân":
                                    if (!db.LeTans.Any(ql => ql.MaNguoiDung == nd.MaNguoiDung))
                                    {
                                        db.LeTans.InsertOnSubmit(new LeTan
                                        {
                                            MaNguoiDung = nd.MaNguoiDung
                                        });
                                    }
                                    break;

                                default:
                                    break;
                            }

                            db.SubmitChanges();
                            transaction.Commit();

                            if (_frmDanhSach != null)
                            {
                                _frmDanhSach.LoadNguoiDung();
                            }

                            CustomMessageBox.Show("Cập nhật thông tin thành công!", "Thông báo", MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        CustomMessageBox.Show("Đã xảy ra lỗi khi lưu thông tin: " + ex.Message, "Lỗi", MessageBoxIcon.Error);
                    }
                    finally
                    {
                        db.Connection.Close();
                    }
                }
                catch (Exception ex)
                {
                    CustomMessageBox.Show("Không thể kết nối đến cơ sở dữ liệu: " + ex.Message, "Lỗi", MessageBoxIcon.Error);
                }
            }
        }

        private void dtpNgaySinhfrmXem_ValueChanged(object sender, EventArgs e)
        {
            dtpNgaySinhfrmXem.Format = DateTimePickerFormat.Short;
            dtpNgaySinhfrmXem.CustomFormat = null;
        }
    }
}
