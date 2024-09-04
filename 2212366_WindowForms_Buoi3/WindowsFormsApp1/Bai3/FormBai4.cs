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
    public partial class FormBai4 : Form
    {
        public FormBai4()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FormBai4_Load(object sender, EventArgs e)
        {
            Random rand = new Random();
            int soNgauNhien;

            for (int i = 0; i < 10; i++)
            {
                soNgauNhien=rand.Next(1, 10);
                listBox1.Items.Add(soNgauNhien);
            }
        }

        private void btnTimSo_Click(object sender, EventArgs e)
        {
            int soDaNhap = int.Parse(txtNhapSo.Text);
            lblKetQua.Text = "Không tìm thấy";
            foreach (int so in listBox1.Items)
            {
                if (so == soDaNhap)
                {
                    lblKetQua.Text = "Tìm thấy";
                    break;
                }
               
            }
            
        }
    }
}
