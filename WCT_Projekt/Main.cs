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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            cbxUserContentCustom.SelectedIndex = 0;
        }

        private void btnData_Click(object sender, EventArgs e)
        {

        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            pnlUser.Visible = true;
            btnUser.BackColor = SystemColors.ControlLightLight;
            btnData.BackColor = SystemColors.ControlLight;
            btnOrganize.BackColor = SystemColors.ControlLight;
            btnInfo.BackColor = SystemColors.ControlLight;
            btnAuswertung.BackColor = SystemColors.ControlLight;
            btnCustom.BackColor = SystemColors.ControlLight;
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            pnlUser.Visible = false;
            btnUser.BackColor = SystemColors.ControlLight;
            btnData.BackColor = SystemColors.ControlLight;
            btnOrganize.BackColor = SystemColors.ControlLight;
            btnInfo.BackColor = SystemColors.ControlLightLight;
            btnAuswertung.BackColor = SystemColors.ControlLight;
            btnCustom.BackColor = SystemColors.ControlLight;
        }

        private void btnOrganize_Click(object sender, EventArgs e)
        {

        }

        private void btnAuswertung_Click(object sender, EventArgs e)
        {

        }

        private void btnCustom_Click(object sender, EventArgs e)
        {

        }

        private void cbxUserContentCustom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxUserContentCustom.SelectedIndex == 0)
            {
                pnlUserContentCustom.Visible = true;
                pnlUserContentCustom2.Visible = false;

            }
            if (cbxUserContentCustom.SelectedIndex == 1)
            {
                pnlUserContentCustom.Visible = false;
                pnlUserContentCustom2.Visible = true;
            }
        }

    }

}
