using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WCT_Projekt {
    class cLabel : Label {

        public Guid guid { get; }

        public cLabel(Guid guid) {
            this.guid = guid;

        }
    }
}
