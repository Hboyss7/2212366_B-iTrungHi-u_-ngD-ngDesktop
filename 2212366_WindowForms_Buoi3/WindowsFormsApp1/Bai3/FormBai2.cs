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
    public partial class FormBai2 : Form
    {
        public FormBai2()
        {
            InitializeComponent();
        }

        private void FormBai2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnChonHang_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(listBox1.SelectedItem);
            //var item = listBox1.SelectedItems;
            //listBox2.Items.Add(item);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnBoHang_Click(object sender, EventArgs e)
        {
            listBox2.Items.Remove(listBox2.SelectedItem);
        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            int soTien = 0;
            foreach (string item in listBox2.Items)
            {
                switch (item)
                {
                    case "Chuột":
                        soTien += 100;
                        break;
                    case "Bàn Phím":
                        soTien += 150;
                        break;
                    case "Máy in":
                        soTien += 2000;
                        break;
                    case "USB KingMax":
                        soTien += 200;
                        break;
                    default:
                        MessageBox.Show("Chưa có mặt hàng");
                        break;
                }

            }
            lblThanhTien.Text = soTien + ".000 đồng";
        }
    }
}
