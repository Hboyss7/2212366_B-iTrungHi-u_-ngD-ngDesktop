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
    public partial class FormBai3 : Form
    {
        public FormBai3()
        {
            InitializeComponent();
        }

        private void btnTinhKQ_Click(object sender, EventArgs e)
        {
            //int a = int.Parse(txtSoA.Text);
            //int b = int.Parse(txtSoB.Text);
            //int n = int.Parse(txtDayn.Text);
            //int kq = PhepTinh.TongDaySo(n);
            //if (rdCongHaiSo.Checked)
            //{
            //    kq = PhepTinh.CongHaiSo(a,b,kq);
            //}
            //lblKetQua.Text = kq.ToString();

            int a,b,n,kq = 0;
            if (rdCongHaiSo.Checked)
            {
                a = int.Parse(txtSoA.Text);
                b = int.Parse(txtSoB.Text);
                PhepTinh.CongHaiSo(a, b, ref kq);
            }
            else
            {
                n = int.Parse(txtDayn.Text);
                kq = PhepTinh.TongDaySo(n);
            }
            lblKetQua.Text = kq.ToString();

        }
    }
}
