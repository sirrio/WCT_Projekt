using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WCT_Projekt;

namespace WindowsFormsApp1
{
    public partial class Main : Form
    {

        User user;
        Data data;
        Organize organize;
        Analyse analyse;
        Info info;
        Custom custom;

        public Main()
        {
            InitializeComponent();

            user = new User();
            data = new Data();
            organize = new Organize();
            analyse = new Analyse();
            info = new Info();
            custom = new Custom();

            user.Parent = pnlContent;
            data.Parent = pnlContent;
            organize.Parent = pnlContent;
            analyse.Parent = pnlContent;
            info.Parent = pnlContent;
            custom.Parent = pnlContent;

            user.Hide();
            data.Show();
            organize.Hide();
            analyse.Hide();
            info.Hide();
            custom.Hide();

        }

        private void btnData_Click(object sender, EventArgs e)
        {
            btnUser.BackColor = SystemColors.ControlLight;
            btnData.BackColor = SystemColors.ControlLightLight;
            btnOrganize.BackColor = SystemColors.ControlLight;
            btnInfo.BackColor = SystemColors.ControlLight;
            btnAnalyse.BackColor = SystemColors.ControlLight;
            btnCustom.BackColor = SystemColors.ControlLight;

            user.Hide();
            data.Show();
            organize.Hide();
            analyse.Hide();
            info.Hide();
            custom.Hide();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            btnUser.BackColor = SystemColors.ControlLightLight;
            btnData.BackColor = SystemColors.ControlLight;
            btnOrganize.BackColor = SystemColors.ControlLight;
            btnInfo.BackColor = SystemColors.ControlLight;
            btnAnalyse.BackColor = SystemColors.ControlLight;
            btnCustom.BackColor = SystemColors.ControlLight;

            user.Show();
            data.Hide();
            organize.Hide();
            analyse.Hide();
            info.Hide();
            custom.Hide();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            btnUser.BackColor = SystemColors.ControlLight;
            btnData.BackColor = SystemColors.ControlLight;
            btnOrganize.BackColor = SystemColors.ControlLight;
            btnInfo.BackColor = SystemColors.ControlLightLight;
            btnAnalyse.BackColor = SystemColors.ControlLight;
            btnCustom.BackColor = SystemColors.ControlLight;

            user.Hide();
            data.Hide();
            organize.Hide();
            analyse.Hide();
            info.Show();
            custom.Hide();
        }

        private void btnOrganize_Click(object sender, EventArgs e)
        {
            btnUser.BackColor = SystemColors.ControlLight;
            btnData.BackColor = SystemColors.ControlLight;
            btnOrganize.BackColor = SystemColors.ControlLightLight;
            btnInfo.BackColor = SystemColors.ControlLight;
            btnAnalyse.BackColor = SystemColors.ControlLight;
            btnCustom.BackColor = SystemColors.ControlLight;

            user.Hide();
            data.Hide();
            organize.Show();
            analyse.Hide();
            info.Hide();
            custom.Hide();
        }

        private void btnAnalyse_Click(object sender, EventArgs e)
        {
            btnUser.BackColor = SystemColors.ControlLight;
            btnData.BackColor = SystemColors.ControlLight;
            btnOrganize.BackColor = SystemColors.ControlLight;
            btnInfo.BackColor = SystemColors.ControlLight;
            btnAnalyse.BackColor = SystemColors.ControlLightLight;
            btnCustom.BackColor = SystemColors.ControlLight;

            user.Hide();
            data.Hide();
            organize.Hide();
            analyse.Show();
            info.Hide();
            custom.Hide();
        }

        private void btnCustom_Click(object sender, EventArgs e)
        {
            btnUser.BackColor = SystemColors.ControlLight;
            btnData.BackColor = SystemColors.ControlLight;
            btnOrganize.BackColor = SystemColors.ControlLight;
            btnInfo.BackColor = SystemColors.ControlLight;
            btnAnalyse.BackColor = SystemColors.ControlLight;
            btnCustom.BackColor = SystemColors.ControlLightLight;

            user.Hide();
            data.Hide();
            organize.Hide();
            analyse.Hide();
            info.Hide();
            custom.Show();
        }

    }

}
