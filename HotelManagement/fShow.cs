﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement
{
    public partial class fShow
        : Form
    {
        public fShow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fLogin f = new fLogin();
            this.Hide();
            f.ShowDialog();
            this.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
