using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

using Act.Framework;
using Act.UI;

namespace WCTACTTicket {
    class Init : IPlugin {
        public static ActFramework fw;
        public static ActApplication actApp;

        private Notification n = null;

        public bool rabAdded { get; set; }


        public void OnLoad(ActApplication actApp) {
            Init.actApp = actApp;
            fw = actApp.ActFramework;

            fw.Connect += new ConnectionEventHandler(ActFramework_Connect);
            fw.Disconnect -= new ConnectionEventHandler(ActFramework_Connect);

            fw.Connect += new ConnectionEventHandler(ActFramework_Disconnect);
        }

        public void OnUnLoad() {
            Connection.sql.Close();
        }

        private void ActFramework_Disconnect(object sender, ConnectionEventArgs e) {
            Connection.sql.Close();

            n.stopTimer();

            actApp.ViewLoaded -= new ViewEventHandler(actAppViewLoaded);
        }

        public void checkUpdates() {
            try {
				// TODO
            }
            catch (Exception e) {
                MessageBox.Show(e.Message);
            }
        }

        private void ActFramework_Connect(object sender, ConnectionEventArgs e) {
            Connection.connect(e);

            if (!Connection.localMode) {
                checkUpdates();
            }

            n = new Notification();

            actApp.ViewLoaded += new ViewEventHandler(actAppViewLoaded);

        }

        private void actAppViewLoaded(object sender, ViewEventArgs e) {
            if ("Act.UI.IContactDetailView" == actApp.CurrentViewName && !tabAdded) {
                cont = new Tab();
                cont.AddTab(e);
                contactTabAdded = true;
            }
        }

    }
}
