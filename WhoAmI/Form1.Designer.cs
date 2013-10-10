namespace LVMCH.WhoAmI {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tbLast = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lbIp = new System.Windows.Forms.Label();
            this.llbAutostartOn = new System.Windows.Forms.LinkLabel();
            this.llbAutostartOff = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbLast
            // 
            this.tbLast.BackColor = System.Drawing.Color.White;
            this.tbLast.Enabled = false;
            this.tbLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLast.Location = new System.Drawing.Point(227, 155);
            this.tbLast.Name = "tbLast";
            this.tbLast.ReadOnly = true;
            this.tbLast.Size = new System.Drawing.Size(132, 80);
            this.tbLast.TabIndex = 0;
            this.tbLast.TabStop = false;
            this.tbLast.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbLast.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Your ip identifier is...";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(-12, -30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(586, 119);
            this.panel1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Verdana", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(75, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 45);
            this.label2.TabIndex = 0;
            this.label2.Text = "WhoAmI?";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbIp
            // 
            this.lbIp.AutoSize = true;
            this.lbIp.Location = new System.Drawing.Point(462, 325);
            this.lbIp.Name = "lbIp";
            this.lbIp.Size = new System.Drawing.Size(88, 13);
            this.lbIp.TabIndex = 6;
            this.lbIp.Text = "000.000.000.000";
            // 
            // llbAutostartOn
            // 
            this.llbAutostartOn.AutoSize = true;
            this.llbAutostartOn.Location = new System.Drawing.Point(65, 325);
            this.llbAutostartOn.Name = "llbAutostartOn";
            this.llbAutostartOn.Size = new System.Drawing.Size(23, 13);
            this.llbAutostartOn.TabIndex = 7;
            this.llbAutostartOn.TabStop = true;
            this.llbAutostartOn.Text = "ON";
            this.llbAutostartOn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbAutostartOn_LinkClicked);
            // 
            // llbAutostartOff
            // 
            this.llbAutostartOff.AutoSize = true;
            this.llbAutostartOff.Location = new System.Drawing.Point(94, 325);
            this.llbAutostartOff.Name = "llbAutostartOff";
            this.llbAutostartOff.Size = new System.Drawing.Size(27, 13);
            this.llbAutostartOff.TabIndex = 8;
            this.llbAutostartOff.TabStop = true;
            this.llbAutostartOff.Text = "OFF";
            this.llbAutostartOff.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbAutostartOff_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 325);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Autostart:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(85, 326);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(12, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "/";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(224, 325);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Please report bugs to MHE";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(562, 347);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.llbAutostartOff);
            this.Controls.Add(this.llbAutostartOn);
            this.Controls.Add(this.lbIp);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbLast);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Lundalogik Virtual Manager Connection Helper";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbLast;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbIp;
        private System.Windows.Forms.LinkLabel llbAutostartOn;
        private System.Windows.Forms.LinkLabel llbAutostartOff;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

