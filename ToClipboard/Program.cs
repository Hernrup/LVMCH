using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LCMCH.ToClipboard {
    class Program {

        [STAThread]
        static void Main(string[] args) {
            try {
                if (args.Length > 0) {
                    Clipboard.SetText(args[0]);
                }
            }
            catch (Exception e) {
                MessageBox.Show(e.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
