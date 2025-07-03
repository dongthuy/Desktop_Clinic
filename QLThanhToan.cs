using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Clinix
{
    public partial class frmQLThanhToan : Form
    {
        DataClasses2DataContext da = new DataClasses2DataContext();

        public frmQLThanhToan()
        {
            InitializeComponent();
        }

        private void frmQLThanhToan_Load(object sender, EventArgs e)
        {
            btnLamMoi_Click(sender, e);

            var listBenhNhan = from bn in da.BenhNhans
                               select new
                               {
                                   bn.MaBenhNhan,
                                   bn.TenBenhNhan
                               };

            cboMaBN.DataSource = listBenhNhan.ToList();
            cboMaBN.DisplayMember = "MaBenhNhan";
            cboMaBN.ValueMember = "MaBenhNhan";
            cboMaBN.SelectedIndex = -1;
            cboMaBN.Text = "Nhập Mã Bệnh Nhân";

            var listPhieuKham = from pk in da.PhieuKhams
                                select new
                                {
                                    pk.MaPhieuKham,
                                    pk.NgayKham
                                };

            cboMaPK.DataSource = listPhieuKham.ToList();
            cboMaPK.DisplayMember = "MaPhieuKham";
            cboMaPK.ValueMember = "MaPhieuKham";
            cboMaPK.SelectedIndex = -1;
            cboMaPK.Text = "Nhập Mã Phiếu Khám";
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            cboMaBN.SelectedIndex = -1;
            cboMaBN.Text = "Nhập Mã Bệnh Nhân";
            cboMaPK.SelectedIndex = -1;
            cboMaPK.Text = "Nhập Mã Phiếu Khám";

            //PhieuKham
            var listPhieuKham = from pk in da.PhieuKhams
                                join bn in da.BenhNhans on pk.MaBenhNhan equals bn.MaBenhNhan
                                select new
                                {
                                    pk.NgayKham,
                                    pk.MaPhieuKham,
                                    bn.MaBenhNhan,
                                    bn.TenBenhNhan,
                                    bn.NgaySinh,
                                    bn.GioiTinh,
                                    bn.SDT
                                };
            dgvPhieuKham.DataSource = listPhieuKham;

            dgvPhieuKham.Columns[0].HeaderText = "Ngày khám";
            dgvPhieuKham.Columns[1].HeaderText = "Mã phiếu khám";
            dgvPhieuKham.Columns[2].HeaderText = "Mã bệnh nhân";
            dgvPhieuKham.Columns[3].HeaderText = "Họ và tên";
            dgvPhieuKham.Columns[4].HeaderText = "Ngày sinh";
            dgvPhieuKham.Columns[5].HeaderText = "Giới tính";
            dgvPhieuKham.Columns[6].HeaderText = "Số điện thoại";

            dgvPhieuKham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPhieuKham.Columns[0].Width = 70;
            dgvPhieuKham.Columns[1].Width = 80;
            dgvPhieuKham.Columns[2].Width = 80;
            dgvPhieuKham.Columns[3].Width = 90;
            dgvPhieuKham.Columns[4].Width = 70;
            dgvPhieuKham.Columns[5].Width = 60;
            dgvPhieuKham.Columns[6].Width = 140;

            dgvPhieuKham.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPhieuKham.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;

            foreach (DataGridViewColumn column in dgvPhieuKham.Columns)
            {
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            dgvPhieuKham.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;

            dgvPhieuKham.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvPhieuKham.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            //PhieuChiDinh
            var phieuChiDinhList = from pcd in da.PhieuChiDinhs
                                   join dv in da.DichVus on pcd.MaDichVu equals dv.MaDichVu
                                   select new PhieuChiDinh
                                   {
                                       MaPhieuKham = pcd.MaPhieuKham,
                                       MaDichVu = dv.MaDichVu,
                                       TenDichVu = dv.TenDichVu,
                                       DonGia = (decimal)dv.DonGia
                                   };

            dgvPhieuChiDinh.DataSource = phieuChiDinhList.ToList();

            dgvPhieuChiDinh.Columns[0].HeaderText = "Mã phiếu khám";
            dgvPhieuChiDinh.Columns[1].HeaderText = "Mã dịch vụ";
            dgvPhieuChiDinh.Columns[2].HeaderText = "Tên dịch vụ";
            dgvPhieuChiDinh.Columns[3].HeaderText = "Đơn giá";

            dgvPhieuChiDinh.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPhieuChiDinh.Columns[0].Width = 50;
            dgvPhieuChiDinh.Columns[1].Width = 40;
            dgvPhieuChiDinh.Columns[2].Width = 100;
            dgvPhieuChiDinh.Columns[3].Width = 120;

            dgvPhieuChiDinh.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPhieuChiDinh.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;

            foreach (DataGridViewColumn column in dgvPhieuChiDinh.Columns)
            {
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            dgvPhieuChiDinh.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;

            dgvPhieuChiDinh.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvPhieuChiDinh.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        public class PhieuChiDinh
        {
            public string MaPhieuKham { get; set; }
            public string MaDichVu { get; set; }
            public string TenDichVu { get; set; }
            public decimal DonGia { get; set; }
        }

        private void cboMaBN_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMaBN.Text != "Nhập Mã Bệnh Nhân")
            {
                string maBenhNhan = cboMaBN.Text;

                var listPhieuKham = from pk in da.PhieuKhams
                                    join bn in da.BenhNhans on pk.MaBenhNhan equals bn.MaBenhNhan
                                    where bn.MaBenhNhan == maBenhNhan
                                    select new
                                    {
                                        pk.NgayKham,
                                        pk.MaPhieuKham,
                                        bn.MaBenhNhan,
                                        bn.TenBenhNhan,
                                        bn.NgaySinh,
                                        bn.GioiTinh,
                                        bn.SDT
                                    };

                dgvPhieuKham.DataSource = listPhieuKham.ToList();

                var listPhieuChiDinh = from pcd in da.PhieuChiDinhs
                                       join dv in da.DichVus on pcd.MaDichVu equals dv.MaDichVu
                                       join pk in da.PhieuKhams on pcd.MaPhieuKham equals pk.MaPhieuKham
                                       join bn in da.BenhNhans on pk.MaBenhNhan equals bn.MaBenhNhan
                                       where bn.MaBenhNhan == maBenhNhan
                                       select new PhieuChiDinh
                                       {
                                           MaPhieuKham = pcd.MaPhieuKham,
                                           MaDichVu = dv.MaDichVu,
                                           TenDichVu = dv.TenDichVu,
                                           DonGia = (decimal)dv.DonGia
                                       };

                dgvPhieuChiDinh.DataSource = listPhieuChiDinh.ToList();
            }
        }

        private void cboMaPK_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMaPK.Text != "Nhập Mã Phiếu Khám")
            {
                string maPhieuKham = cboMaPK.Text;

                // Lọc dữ liệu trong dgvPhieuKham
                var listPhieuKham = from pk in da.PhieuKhams
                                    join bn in da.BenhNhans on pk.MaBenhNhan equals bn.MaBenhNhan
                                    where pk.MaPhieuKham == maPhieuKham
                                    select new
                                    {
                                        pk.NgayKham,
                                        pk.MaPhieuKham,
                                        bn.MaBenhNhan,
                                        bn.TenBenhNhan,
                                        bn.NgaySinh,
                                        bn.GioiTinh,
                                        bn.SDT
                                    };

                dgvPhieuKham.DataSource = listPhieuKham.ToList();

                // Lọc dữ liệu trong dgvPhieuChiDinh
                var listPhieuChiDinh = from pcd in da.PhieuChiDinhs
                                       join dv in da.DichVus on pcd.MaDichVu equals dv.MaDichVu
                                       where pcd.MaPhieuKham == maPhieuKham
                                       select new PhieuChiDinh
                                       {
                                           MaPhieuKham = pcd.MaPhieuKham,
                                           MaDichVu = dv.MaDichVu,
                                           TenDichVu = dv.TenDichVu,
                                           DonGia = (decimal)dv.DonGia
                                       };

                dgvPhieuChiDinh.DataSource = listPhieuChiDinh.ToList();
            }
        }

        private void btnTaoHD_Click(object sender, EventArgs e)
        {
            if (cboMaPK.SelectedValue == null || cboMaPK.SelectedValue.ToString() == "Nhập Mã Phiếu Khám")
            {
                MessageBox.Show("Vui lòng chọn Mã Phiếu Khám!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maPhieuKham = cboMaPK.SelectedValue.ToString();
            decimal tongDonGia = 0;

            foreach (DataGridViewRow row in dgvPhieuChiDinh.Rows)
            {
                if (row.Cells["DonGia"].Value != null)
                {
                    tongDonGia += Convert.ToDecimal(row.Cells["DonGia"].Value);
                }
            }

            frmThemHoaDon frm = new frmThemHoaDon
            {
                MaPhieuKham = maPhieuKham,
                TongDonGia = tongDonGia
            };

            frm.ShowDialog();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {

            Menu trangChu = new Menu();
            trangChu.Show();
        }
    }
}
