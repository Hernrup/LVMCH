using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LVMCH.Connect {
    public partial class Form1 : Form {

        private string baseIp = "212.247.141.";

        public Form1() {
            InitializeComponent();
            this.tbEntry.KeyPress += new System.Windows.Forms.KeyPressEventHandler(CheckKeys);
            //tbIp.Visible = false;
            tbIp.Text = baseIp;
        }


        private void CheckKeys(object sender, System.Windows.Forms.KeyPressEventArgs e) {
            if (e.KeyChar == (char)13) {
                openConnection();
            }
        }

        private void exit() {
            this.Close();
        }

        private void openConnection() {
            
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            //startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "mstsc.exe";
            startInfo.Arguments = "/v:"+tbIp.Text+"";
            process.StartInfo = startInfo;
            process.Start();

            this.exit();
        }

        private void btToggle_Click(object sender, EventArgs e) {
            if (tbIp.Visible == false) {
                tbIp.Visible = true;
            }
            else {
                tbIp.Visible = false;
            }
        }

        private void tbEntry_TextChanged(object sender, EventArgs e) {
            tbIp.Text = baseIp + tbEntry.Text;
        }

        private void panel1_Paint(object sender, PaintEventArgs e) {

        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void tbIp_TextChanged(object sender, EventArgs e) {

        }


     
    }
}
