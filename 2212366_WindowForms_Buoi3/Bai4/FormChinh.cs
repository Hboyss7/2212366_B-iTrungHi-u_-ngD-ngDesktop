﻿using System;
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
    public partial class FormChinh : Form
    {
        public FormChinh()
        {
            InitializeComponent();
        }

        private void tsbBai1_Click(object sender, EventArgs e)
        {
            FormBai1 form = new FormBai1();
            form.ShowDialog();
        }

        private void tsbBai2_Click(object sender, EventArgs e)
        {
            FormBai2 form = new FormBai2();
            form.ShowDialog();
        }

        private void tsbBai3_Click(object sender, EventArgs e)
        {
            FormBai3 form = new FormBai3();
            form.ShowDialog();

        }
    }
}
