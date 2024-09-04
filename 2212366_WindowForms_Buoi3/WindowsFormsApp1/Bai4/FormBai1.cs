using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai4
{
    public partial class FormBai1 : Form
    {
        public FormBai1()
        {
            InitializeComponent();
        }

        private void FormBai1_Load(object sender, EventArgs e)
        {
            HangHoa hh1 = new HangHoa();
            hh1.MaHang = "hh01";
            hh1.TenHang = "Chuột";
            hh1.DVT = "Cái";
            hh1.SoLuong = 5;
            hh1.DonGia = 10000;

            HangHoa hh2 = new HangHoa("hh02", "Nước", "Chai", 10, 5000);

            lblHH1.Text = hh1.HienThi();
            lblHH2.Text = hh2.HienThi();

        }
    }
}
