﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WCT_Projekt
{
    public partial class User : UserControl
    {
        Comp test1;
        Comp2 test2;

        public User()
        {
            InitializeComponent();

            test1 = new Comp();
            test2 = new Comp2();

            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
