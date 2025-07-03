using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Clinix
{
    public partial class ThemNhanVien : Form
    {
        private frmDanhSach _frmDanhSach;

        public ThemNhanVien(frmDanhSach frmDS)
        {
            InitializeComponent();
            _frmDanhSach = frmDS;
        }

        private string PhatSinhMa(string tienTo, IQueryable<string> danhSachMa)
        {
            var maCuoi = danhSachMa.OrderByDescending(ma => ma).FirstOrDefault();

            if (string.IsNullOrEmpty(maCuoi))
                return tienTo + "01";

            int soThuTu = int.Parse(maCuoi.Substring(tienTo.Length)) + 1;
            return tienTo + soThuTu.ToString("D2");
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHoTenfrmThem.Text))
            {               

                CustomMessageBox.Show("Số điện thoại không hợp lệ!\nVui lòng nhập lại!", "Thông báo", MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtDiaChifrmThem.Text))
            {
                CustomMessageBox.Show("Địa chỉ không được để trống.", "Thông báo", MessageBoxIcon.Warning);
                return;
            }

            if (cbGioiTinhfrmThem.SelectedItem == null)
            {
                CustomMessageBox.Show("Vui lòng chọn giới tính.", "Thông báo", MessageBoxIcon.Warning);
                return;
            }

            if (cbChucVufrmThem.SelectedItem == null)
            {
                CustomMessageBox.Show("Vui lòng chức vụ của người dùng.", "Thông báo", MessageBoxIcon.Warning);
                return;
            }

            string soDienThoai = txtSDTfrmThem.Text.Trim();

            if (!KiemTraSDT(soDienThoai))
            {
                CustomMessageBox.Show("Số điện thoại không hợp lệ!\nVui lòng nhập lại!", "Thông báo", MessageBoxIcon.Error);
                return;
            }

            if (cbChucVufrmThem.SelectedItem != null && cbChucVufrmThem.SelectedItem.ToString() == "Bác sĩ")
            {
                if (string.IsNullOrWhiteSpace(txtChuyenMonfrmThem.Text))
                {
                    CustomMessageBox.Show("Chuyên môn của bác sĩ không được để trống.", "Thông báo", MessageBoxIcon.Warning);
                    return;
                }
            }

            DataClasses2DataContext db = new DataClasses2DataContext();

            db.Connection.Open();

            string maNguoiDungMoi = PhatSinhMa("ND", db.NguoiDungs.Select(ndm => ndm.MaNguoiDung));
            string maBacSi = PhatSinhMa("BS", db.BacSis.Select(bs => bs.MaBacSi));
            string maLeTan = PhatSinhMa("LT", db.LeTans.Select(lt => lt.MaLeTan));
            string maQuanLy = PhatSinhMa("QL", db.QuanLies.Select(ql => ql.MaQuanLy));

            NguoiDung nd = new NguoiDung
            {
                MaNguoiDung = maNguoiDungMoi,
                HoTen = txtHoTenfrmThem.Text,
                NgaySinh = dtpNgaySinhfrmThem.Value,
                GioiTinh = cbGioiTinhfrmThem.SelectedValue.ToString(),
                DiaChi = txtDiaChifrmThem.Text,
                SDT = txtSDTfrmThem.Text,
                LoaiNguoiDung = cbChucVufrmThem.SelectedItem.ToString()
            };

            var result = CustomMessageBox.Show("Bạn có chắc chắn muốn thêm mới không?", "Thông báo", MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                db.NguoiDungs.InsertOnSubmit(nd);

                switch (nd.LoaiNguoiDung)
                {
                    case "Bác sĩ":
                        BacSi bacSi = new BacSi
                        {
                            MaBacSi = maBacSi,
                            MaNguoiDung = maNguoiDungMoi,
                            ChuyenMon = txtChuyenMonfrmThem.Text.Trim()
                        };
                        db.BacSis.InsertOnSubmit(bacSi);
                        break;

                    case "Lễ tân":
                        LeTan leTan = new LeTan
                        {
                            MaLeTan = maLeTan,
                            MaNguoiDung = maNguoiDungMoi
                        };
                        db.LeTans.InsertOnSubmit(leTan);
                        break;

                    case "Quản lý":
                        QuanLy quanLy = new QuanLy
                        {
                            MaQuanLy = maQuanLy,
                            MaNguoiDung = maNguoiDungMoi
                        };
                        db.QuanLies.InsertOnSubmit(quanLy);
                        break;

                    case "Y tá":
                        break;
                }

                db.SubmitChanges();

                if (_frmDanhSach != null)
                {
                    _frmDanhSach.LoadNguoiDung();
                }

                CustomMessageBox.Show("Thêm mới thành công!", "Thông báo", MessageBoxIcon.Information);

            }

            db.Connection.Close();
        }

        private void frmThem_Load(object sender, EventArgs e)
        {
            DataClasses2DataContext db = new DataClasses2DataContext();

            db.Connection.Open();

            string maNguoiDungMoi = PhatSinhMa("ND", db.NguoiDungs.Select(nd => nd.MaNguoiDung));
            txtMaNDfrmThem.Text = maNguoiDungMoi;

            cbChucVufrmThem.Height = 25;
            cbGioiTinhfrmThem.Height = 25;
            dtpNgaySinhfrmThem.Height = 25;

            txtMaNDfrmThem.Enabled = false;
            txtMaNVfrmThem.Enabled = false;

            cbGioiTinhfrmThem.DataSource = new List<string> { "Nam", "Nữ" };
            cbGioiTinhfrmThem.SelectedIndex = -1;

            cbChucVufrmThem.DataSource = new List<string> { "Bác sĩ", "Lễ tân", "Quản lý", "Y tá" };
            cbChucVufrmThem.SelectedIndex = -1;

        }

        private void cbChucVufrmThem_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataClasses2DataContext db = new DataClasses2DataContext();

            db.Connection.Open();

            string chucVu = cbChucVufrmThem.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(chucVu))
            {
                txtMaNVfrmThem.Text = string.Empty;
                return;
            }

            if (chucVu == "Lễ tân" || chucVu == "Quản lý" || chucVu == "Y tá")
            {
                txtChuyenMonfrmThem.Enabled = false;
            }
            else
            {
                txtChuyenMonfrmThem.Enabled = true;
            }

            string maNhanVien = string.Empty;
            switch (chucVu)
            {
                case "Bác sĩ":
                    maNhanVien = PhatSinhMa("BS", db.BacSis.Select(bs => bs.MaBacSi));
                    break;

                case "Lễ tân":
                    maNhanVien = PhatSinhMa("LT", db.LeTans.Select(lt => lt.MaLeTan));
                    break;

                case "Quản lý":
                    maNhanVien = PhatSinhMa("QL", db.QuanLies.Select(ql => ql.MaQuanLy));
                    break;

                case "Y tá":
                    return;
            }

            txtMaNVfrmThem.Text = maNhanVien;
        }

        private bool KiemTraSDT(string soDienThoai)
        {
            if (soDienThoai.Length != 10)
                return false;

            if (!soDienThoai.StartsWith("0"))
                return false;

            return soDienThoai.All(char.IsDigit);
        }

        private void btnResetfrmThem_Click(object sender, EventArgs e)
        {
            txtMaNVfrmThem.Clear();
            txtHoTenfrmThem.Clear();
            txtSDTfrmThem.Clear();
            txtDiaChifrmThem.Clear();
            txtChuyenMonfrmThem.Clear();
            dtpNgaySinhfrmThem.Value = DateTime.Now;

            cbGioiTinhfrmThem.SelectedIndex = -1;
            cbChucVufrmThem.SelectedIndex = -1;
            cbGioiTinhfrmThem.SelectedIndex = -1;

            string maNguoiDungMoi = PhatSinhMa("ND", new DataClasses2DataContext().NguoiDungs.Select(ndm => ndm.MaNguoiDung));
            txtMaNDfrmThem.Text = maNguoiDungMoi;
        }

        private void btnDongfrmThem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtpNgaySinhfrmThem_ValueChanged(object sender, EventArgs e)
        {
            dtpNgaySinhfrmThem.Format = DateTimePickerFormat.Short; 
            dtpNgaySinhfrmThem.CustomFormat = null;
        }
    }
}
