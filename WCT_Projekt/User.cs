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
    public partial class User : UserControl
    {
        Comp test1;
        Comp2 test2;

        public User()
        {
            InitializeComponent();

            test1 = new Comp();
            test2 = new Comp2();

            test1.Parent = pnlUserContentCustom;
            test2.Parent = pnlUserContentCustom;

            cbxUserContentCustom.SelectedIndex = 1;
        }

        private void cbxUserContentCustom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxUserContentCustom.SelectedIndex == 0)
            {
                test1.Hide();
                test2.Show();
            }
            else
            {
                test2.Hide();
                test1.Show();
            }
        }

    }
}
