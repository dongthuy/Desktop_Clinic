using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Clinix
{
    public partial class frmQuanLyThongKeLichKham : Form
    {
        public frmQuanLyThongKeLichKham()
        {
            InitializeComponent();
        }
        private DataTable LoadLichHenData()
        {
            DataTable lichHenTable = new DataTable();
            lichHenTable.Columns.Add("MaLichHen", typeof(string)); 
            lichHenTable.Columns.Add("NgayHen", typeof(DateTime));
            lichHenTable.Columns.Add("TrangThai", typeof(string)); 

            using (DataClasses2DataContext db = new DataClasses2DataContext())
            {
                var lichHenList = db.LichHens
                    .Select(lh => new
                    {
                        lh.MaLichHen,
                        NgayHen = lh.NgayHen.HasValue ? lh.NgayHen.Value.Date : (DateTime?)null,
                        lh.TrangThai
                    }).ToList();

                foreach (var item in lichHenList)
                {
                    lichHenTable.Rows.Add(
                        item.MaLichHen,
                        item.NgayHen ?? DateTime.MinValue, 
                        item.TrangThai
                    );
                }
            }

            return lichHenTable;
        }
        private void XuatBC_Click(object sender, EventArgs e)
        {
            DataTable lichHenData = LoadLichHenData(); 
            CrystalReport1 report = new CrystalReport1();
            report.SetDataSource(lichHenData); 
            DateTime fromDate = dtpNgayBDLK.Value;
            DateTime toDate = dtpNgayKTLK.Value;

            if (dtpNgayBDLK.Value > dtpNgayKTLK.Value)
            {
                CustomMessageBox.Show("Ngày bắt đầu trước ngày kết thúc");
                return;
            }

            report.SetParameterValue("NgayBD", fromDate);
            report.SetParameterValue("NgayKT", toDate);
            crystalReportViewer1.ReportSource = report;
            crystalReportViewer1.Refresh();
        }
    }
}
