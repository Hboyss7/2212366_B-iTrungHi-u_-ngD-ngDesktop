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
    public partial class FormBai3 : Form
    {
        List<string> DSNghia = new List<string>();
        public FormBai3()
        {
            InitializeComponent();
        }

        private void btnThemTu_Click(object sender, EventArgs e)
        {
            string nghia = txtNghiaTuMoi.Text;
            listBox1.Items.Add(txtTuMoi.Text);
            DSNghia.Add(txtNghiaTuMoi.Text);

            txtTuMoi.Focus(); // Trỏ chuột về TextBox từ mới
            txtTuMoi.Text = "";  // F5
            txtNghiaTuMoi.Text = "";

            listBox1.SelectedIndex = listBox1.Items.Count - 1;  // Danh mục được chọn là số lượng -1 vì tính [0]
            txtDSNghia.Text = nghia; // ko gan truc tiep vi da f5
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Chỉ số (STT) danh mục được chọn trong danh sách bị thay đổi
            //Selected Index (danh mục được chọn) ở phía bên phải là tự động chọn
            //                                    ở phía bên trái là do người dùng                                        

            var stt = listBox1.SelectedIndex;
            txtDSNghia.Text = DSNghia[stt];
        }
    }
}
