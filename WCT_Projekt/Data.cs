using System;
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
    public partial class Data : UserControl
    {
        Comp comp;
        Comp2 comp2;

        public Data()
        {
            InitializeComponent();

            comp = new Comp();
            comp2 = new Comp2();

            comp.Parent = pnlDataNewEdit;
            comp2.Parent = pnlDataNewEdit;

            comp.Show();
            comp2.Hide();

            comboBox1.SelectedIndex = 0;
        }

        private void Data_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void portraitSmall5_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                comp.Show();
                comp2.Hide();
            }
            else
            {
                comp.Hide();
                comp2.Show();
            }
        }
    }
}
