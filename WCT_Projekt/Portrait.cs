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
    public partial class Portrait : UserControl
    {
        [Description("Portraitname"), Category("Data")]
        public String name
        {
            get { return lblProfil.Text; }
            set { lblProfil.Text = value; }
        }

        [Description("Image"), Category("Data")]
        public Image image
        {
            get { return pbProfil.BackgroundImage; }
            set { pbProfil.BackgroundImage = value; }
        }

        public Portrait()
        {
            InitializeComponent();

            //Bitmap img = new Bitmap("WCT_Projekt.Properties.Resources._new");
            //pbProfil.BackgroundImage = img;
            lblProfil.Text = "Neu";
        }

    }
}
