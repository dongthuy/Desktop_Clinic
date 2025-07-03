using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinix
{
    class HoaDonReport
    {
        public string MaPhieuKham { get; set; }
        public DateTime ExecutionTime { get; set; }
        public string MaHoaDon { get; set; }
        public string MaBenhNhan { get; set; }
        public string TenBenhNhan { get; set; }
        public DateTime NgaySinh { get; set; }
        public string GioiTinh { get; set; }
        public string SDT { get; set; }
        public string MaDichVu { get; set; }
        public string TenDichVu { get; set; }
        public decimal DonGia { get; set; }
        public decimal SoTien { get; set; }
        public string MaLeTan { get; set; }
    }
}
