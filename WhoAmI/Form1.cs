using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace LVMCH.WhoAmI {
    public partial class Form1 : Form {

        private string autostartKeyName = "LVMCHConnect";
        private string assemblyLocation = System.Reflection.Assembly.GetExecutingAssembly().Location;
        
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            string ip = getIp();
            lbIp.Text = ip;
            tbLast.Text = ip.Split(char.Parse(".")).Last();

        }

        private void textBox1_TextChanged(object sender, EventArgs e) {

        }

        public static string getIp() {
            string responceBody;
            string ip = "000.000.000.000";

            try {

                var request = (HttpWebRequest)WebRequest.Create("http://checkip.dyndns.org");

                request.UserAgent = "curl"; // this simulate curl linux command
                request.Method = "GET";

                using (WebResponse response = request.GetResponse()) {
                    using (var reader = new StreamReader(response.GetResponseStream())) {
                        responceBody = reader.ReadToEnd();
                    }
                }

                Regex regexp = new Regex(@"\b\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}\b");
                MatchCollection result = regexp.Matches(responceBody);

                ip = result[0].ToString();

            }
            catch (Exception e) {
                MessageBox.Show(null, string.Format("Ip could not be determined \r\r{0}", e.Message), "Ip could not be determined", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            return ip;
        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void label2_Click(object sender, EventArgs e) {

        }

        private void llbAutostartOn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            // Set Auto-start.
            Autostart.SetAutoStart(autostartKeyName, assemblyLocation);
            MessageBox.Show("Autostart enabled");
        }


        private void llbAutostartOff_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            // Unset Auto-start.
            if (Autostart.IsAutoStartEnabled(autostartKeyName, assemblyLocation)) {
                Autostart.UnSetAutoStart(autostartKeyName);
            }
            MessageBox.Show("Autostart disabled");
        }
    }
}
