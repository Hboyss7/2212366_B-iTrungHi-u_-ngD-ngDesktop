using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    class HangHoa
    {
        public string MaHang { get; set; }

        public string TenHang { get; set; }

        public string DVT { get; set; }

        public int SoLuong { get; set; }

        public int DonGia { get; set; }

        public HangHoa() //ctor
        {

        }

        public HangHoa(string MaHang, string TenHang, string DVT, int SoLuong, int DonGia)
        {
            // CỜ LÊ = Hộp trong ngoặc vuông
            this.MaHang = MaHang;
            this.TenHang = TenHang;
            this.DVT = DVT;
            this.SoLuong = SoLuong;
            this.DonGia = DonGia;

        }

        public string HienThi()
        {
            return string.Format("{0}, {1}, {2}, {3}, {4}", MaHang, TenHang, DVT, SoLuong, DonGia);
        }
    }
}
