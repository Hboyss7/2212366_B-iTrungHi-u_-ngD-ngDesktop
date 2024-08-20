using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Mainfrom : Form
    {
        public Mainfrom()
        {
            InitializeComponent();
        }

        // Sự kiện khi người dùng chọn giới tính Nam
        // Kiểm tra sự thay đổi của Thuộc tính Check ( Thay đổi là khởi chạy phương thức)
        // Để được check mới thông báo thì sử dụng câu lệnh điều kiện

        private void rdNam_CheckedChanged(object sender, EventArgs e)
        {
            if (rdNam.Checked) // rdNam.Checked == True
            {
                MessageBox.Show("Giới tính Nam ", "Thông Báo");
            }
            
        }

        private void rdNu_CheckedChanged(object sender, EventArgs e)
        {
            if (rdNu.Checked) 
            {
                MessageBox.Show("Giới tính Nữ ", "Thông Báo");
            }
        }

        private void btnToMau_Click(object sender, EventArgs e)
        {
            if (rdDo.Checked) 
            {
                txtHopMau.BackColor= Color.Red;
            }
            else
                txtHopMau.BackColor = Color.Yellow;
        }
    }
}
