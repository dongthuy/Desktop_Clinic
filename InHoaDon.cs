using System;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace Clinix
{
    public partial class frmInHoaDon : Form
    {
        DataClasses2DataContext da = new DataClasses2DataContext();
        public string MaHoaDon { get; set; }

        public frmInHoaDon()
        {
            InitializeComponent();
        }

        private void frmInHoaDon_Load(object sender, EventArgs e)
        {
            // Truy vấn dữ liệu từ cơ sở dữ liệu
            var reportData = (from hd in da.HoaDons
                              where hd.MaHoaDon == MaHoaDon
                              join pk in da.PhieuKhams on hd.MaPhieuKham equals pk.MaPhieuKham
                              join pc in da.PhieuChiDinhs on pk.MaPhieuKham equals pc.MaPhieuKham
                              join dv in da.DichVus on pc.MaDichVu equals dv.MaDichVu
                              join bn in da.BenhNhans on pk.MaBenhNhan equals bn.MaBenhNhan
                              join lt in da.LeTans on hd.MaLeTan equals lt.MaLeTan
                              select new HoaDonReport
                              {
                                  MaPhieuKham = hd.MaPhieuKham,
                                  ExecutionTime = DateTime.Now,
                                  MaHoaDon = hd.MaHoaDon,
                                  MaBenhNhan = bn.MaBenhNhan,
                                  TenBenhNhan = bn.TenBenhNhan,
                                  NgaySinh = Convert.ToDateTime(bn.NgaySinh),
                                  GioiTinh = bn.GioiTinh,
                                  SDT = bn.SDT,
                                  MaDichVu = pc.MaDichVu,
                                  TenDichVu = dv.TenDichVu,
                                  DonGia = Convert.ToDecimal(dv.DonGia),
                                  SoTien = Convert.ToDecimal(hd.SoTien),
                                  MaLeTan = lt.MaLeTan
                              }).ToList();

            reportViewer1.LocalReport.ReportPath = "HoaDon.rdlc";

            reportViewer1.LocalReport.DataSources.Clear();

            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("HoaDonDataSet", reportData));
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("BenhNhanDataSet", reportData));
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DichVuDataSet", reportData));

            reportViewer1.RefreshReport();
        }
    }
}