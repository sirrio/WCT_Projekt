using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

using Act.Framework;
using Act.UI;
using System.Collections;

namespace WCTACTTicket {
    public class Tab {
        public ActApplication actApp;
        public ListView lstContacts;
        public ActFramework fw;
        public ComboBox cbxPrio;
        public ComboBox cbxFinish;
        public ComboBox cbxAllOrCurr;
        public ComboBox cbxBillWritten;
        public ComboBox cbxAssigned;
        public ComboBox cbxOwned;
        public List<DTicket> ticketList;
        public Timer timer;

        public Tab() {
            actApp = Init.actApp;
            fw = Init.fw;
            ticketList = new List<DTicket>();
        }

        public void actAppViewChanged(object sender, EventArgs e) {
            refreshAll();
        }

        public void OnTimerEvent(object Source, EventArgs e) {
            try { refreshAll(); }
            catch { }
        }

        public void AddTab(ViewEventArgs e) {
            Tab p = new Tab("Projekt");

            draw(p);

            refreshAll();

            actApp.UILayoutDesignerManager.AddTabToCurrentLayout(p);
        }

        public virtual void draw(TabPage currTab) {
            TableLayoutPanel panelTop = new TableLayoutPanel();
            panelTop.Dock = DockStyle.Top;
            panelTop.Height = 30;
            panelTop.ColumnCount = 14;
            panelTop.RowCount = 1;
            int cbxWidth = 75;

            panelTop.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));

            Button btnNewTicket = new Button();
            panelTop.Controls.Add(btnNewTicket, 1, 0);
            btnNewTicket.AutoSize = true;
            btnNewTicket.Click += new EventHandler(btnClickNewTicket);

            Label lblAllOrCurr = new Label();
            panelTop.Controls.Add(lblAllOrCurr, 2, 0);
            lblAllOrCurr.Anchor = AnchorStyles.Left;
            lblAllOrCurr.AutoSize = true;

            cbxAllOrCurr = new ComboBox();
            cbxAllOrCurr.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxAllOrCurr.Items.AddRange(new string[] { "Nur Kontakt", "Alle" });
            cbxAllOrCurr.Width = cbxWidth;
            panelTop.Controls.Add(cbxAllOrCurr, 3, 0);
            cbxAllOrCurr.SelectedIndex = 0;
            cbxAllOrCurr.SelectedIndexChanged += new EventHandler(refreshAll);

            Label lblPrio = new Label();
            panelTop.Controls.Add(lblPrio, 4, 0);
            lblPrio.Anchor = AnchorStyles.Left;
            lblPrio.AutoSize = true;

            cbxPrio = new ComboBox();
            cbxPrio.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxPrio.Items.AddRange(new string[] { "Niedrig", "Mittel", "Hoch", "Sehr Hoch", "Alle" });
            cbxPrio.Width = cbxWidth;
            panelTop.Controls.Add(cbxPrio, 5, 0);
            cbxPrio.SelectedIndex = 4;
            cbxPrio.SelectedIndexChanged += new EventHandler(refreshAll);


            Label lblFinish = new Label();
            panelTop.Controls.Add(lblFinish, 6, 0);
            lblFinish.Anchor = AnchorStyles.Left;
            lblFinish.AutoSize = true;

            cbxFinish = new ComboBox();
            cbxFinish.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxFinish.Items.AddRange(new string[] { "Alle", "Offen", "Geschlossen" });
            cbxFinish.Width = cbxWidth;
            panelTop.Controls.Add(cbxFinish, 7, 0);
            cbxFinish.SelectedIndex = 0;
            cbxFinish.SelectedIndexChanged += new EventHandler(refreshAll);

            Label lblBillWritten = new Label();
            panelTop.Controls.Add(lblBillWritten, 8, 0);
            lblBillWritten.Anchor = AnchorStyles.Left;
            lblBillWritten.AutoSize = true;

            cbxBillWritten = new ComboBox();
            cbxBillWritten.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxBillWritten.Items.AddRange(new string[] { "Alle", "Offen", "Geschrieben" });
            cbxBillWritten.Width = cbxWidth;
            panelTop.Controls.Add(cbxBillWritten, 9, 0);
            cbxBillWritten.SelectedIndex = 1;
            cbxBillWritten.SelectedIndexChanged += new EventHandler(refreshAll);

            Label lblAssigned = new Label();
            panelTop.Controls.Add(lblAssigned, 10, 0);
            lblAssigned.Anchor = AnchorStyles.Left;
            lblAssigned.AutoSize = true;

            SqlCommand cmd = new SqlCommand("select userid, lastname from tbl_user inner join tbl_contact on userid=tbl_contact.contactid", Connection.sql);
            SqlDataReader dr = cmd.ExecuteReader();
            cbxAssigned = new ComboBox();
            cbxAssigned.DropDownStyle = ComboBoxStyle.DropDownList;
            DItem itemAll = new DItem();
            itemAll.Value = -1;
            cbxAssigned.Items.Add(itemAll);
            while (dr.Read()) {
                DItem item = new DItem();
                item.Text = dr.GetString(1);
                item.Value = dr.GetGuid(0).ToString();
                cbxAssigned.Items.Add(item);
            }
            cbxAssigned.Width = cbxWidth;
            panelTop.Controls.Add(cbxAssigned, 11, 0);
            cbxAssigned.SelectedIndex = 0;
            cbxAssigned.SelectedIndexChanged += new EventHandler(refreshAll);
            dr.Close();

            Label lblOwned = new Label();
            panelTop.Controls.Add(lblOwned, 12, 0);
            lblOwned.Anchor = AnchorStyles.Left;
            lblOwned.AutoSize = true;

            cbxOwned = new ComboBox();
            cbxOwned.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxOwned.Width = cbxWidth;
            panelTop.Controls.Add(cbxOwned, 13, 0);
            cbxOwned.SelectedIndex = 0;
            cbxOwned.SelectedIndexChanged += new EventHandler(refreshAll);

            lstContacts = new ListView();
            Panel panelBot = new Panel();
            panelBot.Dock = DockStyle.Fill;
            panelBot.AutoSize = true;
            panelBot.Controls.Add(this.lstContacts);
            lstContacts.View = View.Details;
            lstContacts.FullRowSelect = true;
            lstContacts.Scrollable = true;
            lstContacts.MouseDoubleClick += new MouseEventHandler(listView_MouseDoubleClick);
            lstContacts.Dock = System.Windows.Forms.DockStyle.Fill;

            currTab.Controls.Add(panelBot);
            currTab.Controls.Add(panelTop);

            lstContacts.Columns.Add(new ColHeader("ID", -1, HorizontalAlignment.Left, true));
            lstContacts.Columns.Add(new ColHeader("Name", -1, HorizontalAlignment.Left, true));

            lstContacts.ColumnClick += (listView1_ColumnClick);

            startTimer();
        }

        public void startTimer() {
            timer = new Timer();
            timer.Enabled = true;
            timer.Interval = 60000;
            timer.Tick += new System.EventHandler(this.OnTimerEvent);
        }

        public void listView1_ColumnClick(object sender, ColumnClickEventArgs e) {
            // Create an instance of the ColHeader class.
            ColHeader clickedCol = (ColHeader)this.lstContacts.Columns[e.Column];

            // Set the ascending property to sort in the opposite order.
            clickedCol.ascending = !clickedCol.ascending;

            // Get the number of items in the list.
            int numItems = this.lstContacts.Items.Count;

            // Turn off display while data is repoplulated.
            this.lstContacts.BeginUpdate();

            // Populate an ArrayList with a SortWrapper of each list item.
            ArrayList SortArray = new ArrayList();
            for (int i = 0; i < numItems; i++) {
                SortArray.Add(new SortWrapper(this.lstContacts.Items[i], e.Column));
            }

            // Sort the elements in the ArrayList using a new instance of the SortComparer
            // class. The parameters are the starting index, the length of the range to sort,
            // and the IComparer implementation to use for comparing elements. Note that
            // the IComparer implementation (SortComparer) requires the sort
            // direction for its constructor; true if ascending, othwise false.
            SortArray.Sort(0, SortArray.Count, new SortWrapper.SortComparer(clickedCol.ascending));

            // Clear the list, and repopulate with the sorted items.
            this.lstContacts.Items.Clear();
            for (int i = 0; i < numItems; i++)
                this.lstContacts.Items.Add(((SortWrapper)SortArray[i]).sortItem);

            // Turn display back on.
            this.lstContacts.EndUpdate();
        }

        public virtual void refreshAll() {
            DTicket ticket = new DTicket();
            ticket.ID = 1;

            lstContacts.BeginUpdate();

            lstContacts.Items.Clear();
            ticketList.Clear();

            Connection.sqlLoadAllTickets(ticketList);

            Connection.sqlLoadAllAssigns(ticketList);

            foreach (DTicket curTicket in Enumerable.Reverse(ticketList)) {
                switch (cbxPrio.Text) {
                    case "Niedrig": if (curTicket.priority != 0) { continue; }; break;
                    case "Mittel": if (curTicket.priority != 1) { continue; }; break;
                    case "Hoch": if (curTicket.priority != 2) { continue; }; break;
                    case "Sehr Hoch": if (curTicket.priority != 3) { continue; }; break;
                    case "Alle":; break;
                }

                switch (cbxFinish.SelectedIndex) {
                    case 0:; break;
                    case 1: if (curTicket.finished) { continue; }; break;
                    case 2: if (!curTicket.finished) { continue; }; break;
                }

                switch (cbxAllOrCurr.SelectedIndex) {
                    case 1:; break;
                    case 0: if (curTicket.contact != actApp.ApplicationState.CurrentContact.ID) { continue; }; break;
                }

                switch (cbxBillWritten.SelectedIndex) {
                    case 0:; break;
                    case 1: if (curTicket.billWritten) { continue; }; break;
                    case 2: if (!curTicket.billWritten) { continue; }; break;
                }

                if (!((cbxAssigned.SelectedItem as DItem).Value.ToString() == "-1")) {
                    if (!compareAssign(curTicket, (cbxAssigned.SelectedItem as DItem).Value.ToString())) {
                        if (!(curTicket.owner.ToString() == (cbxAssigned.SelectedItem as DItem).Value.ToString())) {
                            continue;
                        }
                    }
                }

                switch (cbxOwned.SelectedIndex) {
                    case 0:; break;
                    case 1: if (curTicket.owner != fw.CurrentUser.ID) { continue; }; break;
                }

                lstContacts.Items.Add(ticketValuesToList(curTicket));

            }

            if (lstContacts.Items.Count == 0) { lstContacts.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize); }
            else {
                lstContacts.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                lstContacts.AutoResizeColumn(lstContacts.Columns.Count - 1, ColumnHeaderAutoResizeStyle.HeaderSize);
                lstContacts.AutoResizeColumn(lstContacts.Columns.Count - 2, ColumnHeaderAutoResizeStyle.HeaderSize);
            }

            lstContacts.EndUpdate();

        }

        public bool compareAssign(DTicket curTicket, string selectedAssign) {
            foreach (DAssign assign in curTicket.getListAssign) {
                if (assign.userID.ToString() == selectedAssign) {
                    return true;
                }
            }
            return false;
        }

        public ListViewItem ticketValuesToList(DTicket curTicket) {
            ListViewItem item;
            item = new ListViewItem();
            item.Text = curTicket.ID.ToString();
            item.SubItems.Add(curTicket.companyName);
            item.SubItems.Add(curTicket.contactName);
            switch (curTicket.priority) {
                case 0: item.SubItems.Add("Niedrig"); break;
                case 1: item.SubItems.Add("Mittel"); break;
                case 2: item.SubItems.Add("Hoch").ForeColor = Color.OrangeRed; break;
                case 3: item.SubItems.Add("Sehr Hoch").ForeColor = Color.Red; break;
            }
            string date = curTicket.date.ToShortDateString() + "   " + curTicket.date.ToShortTimeString();
            item.SubItems.Add(date);
            item.SubItems.Add(curTicket.subject);
            string assignsStr = "";
            bool currUserIsAssigned = false;
            bool nobodyIsAssigned = false;
            if (curTicket.owner != Guid.Empty) {
                item.SubItems.Add(curTicket.ownerName).ForeColor = Color.Blue;
            }
            else {
                foreach (DAssign assign in curTicket.getListAssign) {
                    if (assign.userID == fw.CurrentUser.ID) {
                        currUserIsAssigned = true;
                    }

                    assignsStr = assignsStr + assign.name + "; ";
                }
                if (assignsStr == "") { assignsStr = "Niemand"; nobodyIsAssigned = true; }
                else { assignsStr = assignsStr.Substring(0, assignsStr.Length - 2); }
                if (currUserIsAssigned) {
                    item.SubItems.Add(assignsStr).ForeColor = System.Drawing.Color.Green;
                }
                else {
                    if (nobodyIsAssigned) {
                        item.SubItems.Add(assignsStr).ForeColor = System.Drawing.Color.Black;
                    }
                    else {
                        item.SubItems.Add(assignsStr).ForeColor = System.Drawing.Color.Red;
                    }
                }
            }
            item.UseItemStyleForSubItems = false;
            if (curTicket.finished) { item.SubItems.Add("Geschlossen"); }
            else { item.SubItems.Add("Offen"); }
            if (curTicket.billWritten) { item.SubItems.Add("Rechnung geschrieben"); }
            else { item.SubItems.Add("Offen"); }
            if (curTicket.owner == fw.CurrentUser.ID) {
                item.BackColor = Color.LightSteelBlue;
                for (int i = 0; i < item.SubItems.Count; i++) {
                    item.SubItems[i].BackColor = Color.LightSteelBlue;
                }
            }
            return item;
        }

        public void refreshAll(object sender, EventArgs e) {
            refreshAll();


        }

        public virtual void btnClickNewTicket(object sender, EventArgs e) {

        }

        public virtual void listView_MouseDoubleClick(object sender, EventArgs e) {

        }

    }
}
