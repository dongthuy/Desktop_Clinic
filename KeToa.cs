using Microsoft.Reporting.WinForms;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Clinix
{
    public partial class KeToa : Form
    {
        DataClasses2DataContext da = new DataClasses2DataContext();

        public string MaPhieuKham { get; set; }
        public KeToa(string maPhieuKham)
        {
            InitializeComponent();
            MaPhieuKham = maPhieuKham;
        }

        private void KeToa_Load(object sender, EventArgs e)
        {
            var reportData = (from bn in da.BenhNhans
                              join pk in da.PhieuKhams on bn.MaBenhNhan equals pk.MaBenhNhan
                              join dt in da.DonThuocs on pk.MaPhieuKham equals dt.MaPhieuKham
                              join ctdt in da.ChiTietDonThuocs on dt.MaDonThuoc equals ctdt.MaDonThuoc
                              join t in da.Thuocs on ctdt.MaThuoc equals t.MaThuoc
                              where pk.MaPhieuKham == MaPhieuKham
                              select new InDV
                              {
                                  // BenhNhan
                                  MaBenhNhan = bn.MaBenhNhan,
                                  TenBenhNhan = bn.TenBenhNhan,
                                  NgaySinh = Convert.ToDateTime(bn.NgaySinh),
                                  GioiTinh = bn.GioiTinh,
                                  DiaChi = bn.DiaChi,
                                  SDT = bn.SDT,

                                  // PhieuKham
                                  MaPhieuKham = pk.MaPhieuKham,
                                  ChanDoan = pk.ChanDoan,
                                  NgayKham = Convert.ToDateTime(pk.NgayKham),
                                  
                                  // DonThuoc
                                  GhiChu = dt.GhiChu,

                                  // ChiTietDonThuoc
                                  MaThuoc = ctdt.MaThuoc,
                                  SoLuong = (int)ctdt.SoLuong,
                                  LieuLuong = ctdt.LieuLuong,

                                  // Thuoc
                                  TenThuoc = t.TenThuoc,
                                  DVT = t.DVT,
                              }).ToList();

            reportViewer1.LocalReport.ReportPath = "inKeToa.rdlc";

            reportViewer1.LocalReport.DataSources.Clear();

            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("BenhNhan", reportData));
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("PhieuKham", reportData));
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DonThuoc", reportData));
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("ChiTietDonThuoc", reportData));
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("Thuoc", reportData));

            this.reportViewer1.RefreshReport();
        }
    }
}
