using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WCT_Projekt {
    public partial class Custom : UserControl {

        public Custom() {
            InitializeComponent();
        }

        bool isDragged = false;
        Point pOffset;
        Dictionary<Guid, Control> controls = new Dictionary<Guid, Control>();
        Dictionary<Guid, Control> backup = new Dictionary<Guid, Control>();
        Guid currentControl;

        private void btnNew_MouseDown(object sender, MouseEventArgs e) {
            //((Button) sender).Location = e.Location;
            isDragged = true;
            pOffset = e.Location;

            foreach (KeyValuePair<Guid, Control> item in controls) {
                if (item.Value is cButton) {
                    item.Value.BackColor = SystemColors.Control;
                }
                if (item.Value is cTextBox) {
                    item.Value.BackColor = SystemColors.Window;
                }
                if (item.Value is cLabel) {
                    item.Value.BackColor = SystemColors.ControlLight;
                }
            }

            lblMulti.Visible = false;
            cbxMulti.Visible = false;

            ((Control)sender).BackColor = Color.Yellow;
            currentControl = ((cButton)sender).guid;

            crtGuid.Text = ((cButton)sender).guid.ToString();
            ctrText.Text = ((cButton)sender).Text;
            ctrSizeWidth.Value = ((Control)sender).Size.Width;
            ctrSizeHeight.Value = ((Control)sender).Size.Height;
        }

        private void btnNew_MouseMove(object sender, MouseEventArgs e) {
            if (isDragged) {
                Point p = ((cButton)sender).PointToScreen(e.Location);
                p.X = p.X - pOffset.X;
                p.Y = p.Y - pOffset.Y;
                Point q = pnlSample.PointToClient(p);
                ((cButton)sender).Location = new Point(snap(q.X), snap(q.Y));
            }
        }

        private void btnNew_MouseUp(object sender, MouseEventArgs e) {
            isDragged = false;
        }

        private void txtNew_MouseDown(object sender, MouseEventArgs e) {
            isDragged = true;
            pOffset = e.Location;

            foreach (KeyValuePair<Guid, Control> item in controls) {
                if (item.Value is cButton) {
                    item.Value.BackColor = SystemColors.Control;
                }
                if (item.Value is cTextBox) {
                    item.Value.BackColor = SystemColors.Window;
                }
                if (item.Value is cLabel) {
                    item.Value.BackColor = SystemColors.ControlLight;
                }
            }

            lblMulti.Visible = true;
            cbxMulti.Visible = true;

            ((cTextBox)sender).BackColor = Color.Yellow;
            currentControl = ((cTextBox)sender).guid;

            crtGuid.Text = ((cTextBox)sender).guid.ToString();
            ctrText.Text = ((cTextBox)sender).Text;
            ctrSizeWidth.Value = ((Control)sender).Size.Width;
            ctrSizeHeight.Value = ((Control)sender).Size.Height;
        }

        private void txtNew_MouseMove(object sender, MouseEventArgs e) {
            if (isDragged) {
                Point p = ((cTextBox)sender).PointToScreen(e.Location);
                p.X = p.X - pOffset.X;
                p.Y = p.Y - pOffset.Y;
                Point q = pnlSample.PointToClient(p);
                ((cTextBox)sender).Location = new Point(snap(q.X), snap(q.Y));
            }
        }

        private void txtNew_MouseUp(object sender, MouseEventArgs e) {
            isDragged = false;
        }


        private void lblNew_MouseDown(object sender, MouseEventArgs e) {
            isDragged = true;
            pOffset = e.Location;

            foreach (KeyValuePair<Guid, Control> item in controls) {
                if (item.Value is cButton) {
                    item.Value.BackColor = SystemColors.Control;
                }
                if (item.Value is cTextBox) {
                    item.Value.BackColor = SystemColors.Window;
                }
                if (item.Value is cLabel) {
                    item.Value.BackColor = SystemColors.ControlLight;
                } 
            }

            lblMulti.Visible = false;
            cbxMulti.Visible = false;

            ((cLabel)sender).BackColor = Color.Yellow;
            currentControl = ((cLabel)sender).guid;

            crtGuid.Text = ((cLabel)sender).guid.ToString();
            ctrText.Text = ((cLabel)sender).Text;
            ctrSizeWidth.Value = ((Control)sender).Size.Width;
            ctrSizeHeight.Value = ((Control)sender).Size.Height;

        }

        private void lblNew_MouseMove(object sender, MouseEventArgs e) {
            if (isDragged) {
                Point p = ((cLabel)sender).PointToScreen(e.Location);
                p.X = (p.X - pOffset.X) ;
                p.Y = p.Y - pOffset.Y;
                Point q = pnlSample.PointToClient(p);
                ((cLabel)sender).Location = new Point(snap(q.X), snap(q.Y));
            }
        }

        private void lblNew_MouseUp(object sender, MouseEventArgs e) {
            isDragged = false;
        }

        private int snap(int value) {
            if (value % 10 > 5) {
                value = value + 10 - (value % 10);
            } else {
                value = value - (value % 10);
            }

            return value;
        }

        private void btnSample_Click(object sender, EventArgs e) {
            Guid guid = Guid.NewGuid();
            cButton btnNew = new cButton(guid);
            controls.Add(guid, btnNew);
            btnNew.Size = new Size(75, 23);
            btnNew.Visible = true;
            btnNew.Location = new Point(1, 1);
            btnNew.BackColor = SystemColors.Control;
            btnNew.Text = "Button";
            btnNew.MouseDown += new MouseEventHandler(btnNew_MouseDown);
            btnNew.MouseMove += new MouseEventHandler(btnNew_MouseMove);
            btnNew.MouseUp += new MouseEventHandler(btnNew_MouseUp);
            pnlSample.Controls.Add(btnNew);
        }

        private void txtSample_Click(object sender, EventArgs e) {
            Guid guid = Guid.NewGuid();
            cTextBox txtNew = new cTextBox(guid);
            controls.Add(guid, txtNew);
            txtNew.Size = new Size(100, 20);
            txtNew.Visible = true;
            txtNew.Location = new Point(1, 1);
            txtNew.BackColor = SystemColors.Control;
            txtNew.Text = "Textfeld";
            txtNew.MouseDown += new MouseEventHandler(txtNew_MouseDown);
            txtNew.MouseMove += new MouseEventHandler(txtNew_MouseMove);
            txtNew.MouseUp += new MouseEventHandler(txtNew_MouseUp);
            pnlSample.Controls.Add(txtNew);
        }

        private void lblSample_Click(object sender, EventArgs e) {
            Guid guid = Guid.NewGuid();
            cLabel lblNew = new cLabel(guid);
            controls.Add(guid, lblNew);
            lblNew.TextAlign = ContentAlignment.MiddleLeft;
            lblNew.BackColor = SystemColors.ControlLight;
            lblNew.Size = new Size(70, 20);
            lblNew.Visible = true;
            lblNew.Location = new Point(1, 1);
            lblNew.Text = "Beschriftung";
            lblNew.MouseDown += new MouseEventHandler(lblNew_MouseDown);
            lblNew.MouseMove += new MouseEventHandler(lblNew_MouseMove);
            lblNew.MouseUp += new MouseEventHandler(lblNew_MouseUp);
            pnlSample.Controls.Add(lblNew);
        }

        private void btnSave_Click(object sender, EventArgs e) {
            controls[currentControl].Text = ctrText.Text;
            controls[currentControl].Size = new Size(Decimal.ToInt32(ctrSizeWidth.Value),Decimal.ToInt32(ctrSizeHeight.Value));
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {
            foreach (KeyValuePair<Guid, Control> item in controls) {
                item.Value.Visible = false;
            }
            Dictionary<Guid, Control> tmp = controls;
            controls = backup;
            backup = tmp;
            foreach (KeyValuePair<Guid, Control> item in controls) {
                item.Value.Visible = true;
            }
        }

        private void cbxMulti_Click(object sender, EventArgs e) {
            if (!cbxMulti.Checked) {
                ((cTextBox)controls[currentControl]).Multiline = false;
                ((cTextBox)controls[currentControl]).Size = new Size(100, 20);
            } else {
                ((cTextBox)controls[currentControl]).Multiline = true;
                ((cTextBox)controls[currentControl]).Size = new Size(300, 200);
            }
            ctrSizeWidth.Value = ((cTextBox)controls[currentControl]).Size.Width;
            ctrSizeHeight.Value = ((cTextBox)controls[currentControl]).Size.Height;
        }
    }
}
