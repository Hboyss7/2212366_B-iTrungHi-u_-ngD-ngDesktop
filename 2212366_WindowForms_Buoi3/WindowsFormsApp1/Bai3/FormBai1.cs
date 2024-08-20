using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai3
{
    public partial class FormBai1 : Form
    {
        public FormBai1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void rdTrang_CheckedChanged(object sender, EventArgs e)
        {
            if (rdTrang.Checked)
            {
                txtDonGia.Text = "20000";
            }
        }

        private void rdXanh_CheckedChanged(object sender, EventArgs e)
        {

            if (rdXanh.Checked)
            {
                txtDonGia.Text = "22000";
            }
        }

        private void rdDo_CheckedChanged(object sender, EventArgs e)
        {
            if (rdDo.Checked)
            {
                txtDonGia.Text = "21000";
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FormBai1_Load(object sender, EventArgs e)
        {

        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            
        }
    }
}
