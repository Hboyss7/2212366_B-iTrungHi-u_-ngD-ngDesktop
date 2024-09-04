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
    public partial class FormBai2 : Form
    {
        public FormBai2()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbbTenHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSoLuong.Text = "";
            //C1:
            //if (cbbTenHang.SelectedItem == "Chuột")
            //{
            //    txtDonGia.Text = "100000";
            //}
            
            int stt = cbbTenHang.SelectedIndex;
            switch (stt)
            {
                case 0:
                    txtDonGia.Text = "100000";
                    break;
                case 1:
                    txtDonGia.Text = "2000000";
                    break;
                case 2:
                    txtDonGia.Text = "150000";
                    break;
                default:
                    break;
            }
        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            
            int donGia = int.Parse(txtDonGia.Text);
            int soLuong = int.Parse(txtSoLuong.Text);
            double tinhTien = soLuong * donGia;
            if (rdChuyenKhoan.Checked)
            {
                tinhTien = soLuong * donGia - 0.05*soLuong * donGia;
            }
            lblThanhToan.Text = tinhTien.ToString();
            

        }
    }
}
