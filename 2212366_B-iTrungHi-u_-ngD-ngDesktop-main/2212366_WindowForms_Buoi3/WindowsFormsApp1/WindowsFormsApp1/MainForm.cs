using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
       

        // Sự kiện click
        private void btnOK_Click(object sender, EventArgs e)
        {
            string tenDaNhap = txtTen.Text;
            MessageBox.Show($"Mày tên là {tenDaNhap}","Thông Báo");
        }

        //Hộp sao chép không cho phép gõ ( ReadOnly True), chỉ sao chép bên trên
        private void btnSaoChep_Click(object sender, EventArgs e)
        {
            txtSaoChep.Text = txtTen.Text;
        }
        // Xử lý thay đổi text
        private void txtTen_TextChanged(object sender, EventArgs e)
        {
            txtSaoChep.Text = txtTen.Text;
        }


        private void txtSaoChep_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
