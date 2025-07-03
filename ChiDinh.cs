using Microsoft.Reporting.WinForms;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Clinix
{
    public partial class ChiDinh : Form
    {
        DataClasses2DataContext da = new DataClasses2DataContext();
        public string MaPhieuKham { get; set; }
        public ChiDinh(string maPhieuKham)
        {
            InitializeComponent();
            MaPhieuKham = maPhieuKham; 
        }

        private void ChiDinh_Load(object sender, EventArgs e)
        {
            var reportData = (from pk in da.PhieuKhams
                              where pk.MaPhieuKham == MaPhieuKham
                              join pc in da.PhieuChiDinhs on pk.MaPhieuKham equals pc.MaPhieuKham
                              join dv in da.DichVus on pc.MaDichVu equals dv.MaDichVu
                              join bn in da.BenhNhans on pk.MaBenhNhan equals bn.MaBenhNhan
                              join bs in da.BacSis on pk.MaBacSi equals bs.MaBacSi
                              select new InDV
                              {
                                  MaPhieuKham = pk.MaPhieuKham,
                                  ChanDoan = pk.ChanDoan,
                                  NgayKham = Convert.ToDateTime(pk.NgayKham),
                                  MaBenhNhan = bn.MaBenhNhan,
                                  TenBenhNhan = bn.TenBenhNhan,
                                  NgaySinh = Convert.ToDateTime(bn.NgaySinh),
                                  GioiTinh = bn.GioiTinh,
                                  DiaChi = bn.DiaChi,
                                  SDT = bn.SDT,
                                  MaDichVu = pc.MaDichVu,
                                  TenDichVu = dv.TenDichVu,
                                  DonGia = Convert.ToDecimal(dv.DonGia)
                                 
                              }).ToList();

            reportViewer1.LocalReport.ReportPath = "rpChiDinh.rdlc";

            reportViewer1.LocalReport.DataSources.Clear();

            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("PhieuKham", reportData));
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("BenhNhan", reportData));
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DichVu", reportData));
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("BacSi", reportData));
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("PhieuChiDinh", reportData));

            this.reportViewer1.RefreshReport();
        }
    }
}
