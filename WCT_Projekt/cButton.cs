using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WCT_Projekt {
    class cButton : Button {

        public Guid guid { get; }

        public cButton(Guid guid) {
            this.guid = guid;
        }

    }
}
