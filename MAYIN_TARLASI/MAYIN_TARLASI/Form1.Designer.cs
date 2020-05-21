namespace MAYIN_TARLASI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.baslaBtn = new System.Windows.Forms.Button();
            this.mayinTarlasiPnl = new System.Windows.Forms.Panel();
            this.mayinSayisiNUD = new System.Windows.Forms.NumericUpDown();
            this.sureNUD = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.süreLbl = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.soru1Panel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.parametrelerGroupbox = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.armstrongLbl = new System.Windows.Forms.Label();
            this.ustSinirTxt = new System.Windows.Forms.TextBox();
            this.altSinirTxt = new System.Windows.Forms.TextBox();
            this.armstrongLst = new System.Windows.Forms.ListBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.bulBtn = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mayinSayisiNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sureNUD)).BeginInit();
            this.soru1Panel.SuspendLayout();
            this.parametrelerGroupbox.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // baslaBtn
            // 
            this.baslaBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.baslaBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.baslaBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.baslaBtn.Location = new System.Drawing.Point(204, 507);
            this.baslaBtn.Name = "baslaBtn";
            this.baslaBtn.Size = new System.Drawing.Size(83, 26);
            this.baslaBtn.TabIndex = 0;
            this.baslaBtn.Text = "BAŞLA";
            this.baslaBtn.UseVisualStyleBackColor = false;
            this.baslaBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // mayinTarlasiPnl
            // 
            this.mayinTarlasiPnl.BackColor = System.Drawing.Color.White;
            this.mayinTarlasiPnl.Location = new System.Drawing.Point(12, 67);
            this.mayinTarlasiPnl.Name = "mayinTarlasiPnl";
            this.mayinTarlasiPnl.Size = new System.Drawing.Size(275, 275);
            this.mayinTarlasiPnl.TabIndex = 3;
            // 
            // mayinSayisiNUD
            // 
            this.mayinSayisiNUD.Location = new System.Drawing.Point(120, 24);
            this.mayinSayisiNUD.Name = "mayinSayisiNUD";
            this.mayinSayisiNUD.Size = new System.Drawing.Size(120, 22);
            this.mayinSayisiNUD.TabIndex = 4;
            // 
            // sureNUD
            // 
            this.sureNUD.Location = new System.Drawing.Point(120, 50);
            this.sureNUD.Name = "sureNUD";
            this.sureNUD.Size = new System.Drawing.Size(120, 22);
            this.sureNUD.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mayın Sayısı =";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Süre (sn) =";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label3.Location = new System.Drawing.Point(19, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kalan Süre =";
            // 
            // süreLbl
            // 
            this.süreLbl.AutoSize = true;
            this.süreLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.süreLbl.ForeColor = System.Drawing.SystemColors.Desktop;
            this.süreLbl.Location = new System.Drawing.Point(120, 15);
            this.süreLbl.Name = "süreLbl";
            this.süreLbl.Size = new System.Drawing.Size(40, 16);
            this.süreLbl.TabIndex = 5;
            this.süreLbl.Text = "____";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-3, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "label4";
            this.label4.Visible = false;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(53, 649);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(99, 186);
            this.listBox1.TabIndex = 1;
            this.listBox1.Visible = false;
            // 
            // soru1Panel
            // 
            this.soru1Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(205)))), ((int)(((byte)(219)))));
            this.soru1Panel.Controls.Add(this.label5);
            this.soru1Panel.Location = new System.Drawing.Point(12, 12);
            this.soru1Panel.Name = "soru1Panel";
            this.soru1Panel.Size = new System.Drawing.Size(275, 46);
            this.soru1Panel.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(95, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "SORU 1:";
            // 
            // parametrelerGroupbox
            // 
            this.parametrelerGroupbox.BackColor = System.Drawing.SystemColors.Control;
            this.parametrelerGroupbox.Controls.Add(this.mayinSayisiNUD);
            this.parametrelerGroupbox.Controls.Add(this.sureNUD);
            this.parametrelerGroupbox.Controls.Add(this.label1);
            this.parametrelerGroupbox.Controls.Add(this.label4);
            this.parametrelerGroupbox.Controls.Add(this.label2);
            this.parametrelerGroupbox.Cursor = System.Windows.Forms.Cursors.Default;
            this.parametrelerGroupbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.parametrelerGroupbox.ForeColor = System.Drawing.SystemColors.Highlight;
            this.parametrelerGroupbox.Location = new System.Drawing.Point(16, 358);
            this.parametrelerGroupbox.Name = "parametrelerGroupbox";
            this.parametrelerGroupbox.Size = new System.Drawing.Size(271, 132);
            this.parametrelerGroupbox.TabIndex = 8;
            this.parametrelerGroupbox.TabStop = false;
            this.parametrelerGroupbox.Text = "Parametreler";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(205)))), ((int)(((byte)(219)))));
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.süreLbl);
            this.panel3.Location = new System.Drawing.Point(13, 497);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(185, 46);
            this.panel3.TabIndex = 9;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gray;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.panel9);
            this.panel4.Controls.Add(this.ustSinirTxt);
            this.panel4.Controls.Add(this.altSinirTxt);
            this.panel4.Controls.Add(this.armstrongLst);
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.panel8);
            this.panel4.Controls.Add(this.bulBtn);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel4.Location = new System.Drawing.Point(349, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(290, 548);
            this.panel4.TabIndex = 10;
            // 
            // panel9
            // 
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel9.Controls.Add(this.armstrongLbl);
            this.panel9.Location = new System.Drawing.Point(15, 426);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(251, 100);
            this.panel9.TabIndex = 10;
            // 
            // armstrongLbl
            // 
            this.armstrongLbl.AutoSize = true;
            this.armstrongLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.armstrongLbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.armstrongLbl.Location = new System.Drawing.Point(59, 38);
            this.armstrongLbl.Name = "armstrongLbl";
            this.armstrongLbl.Size = new System.Drawing.Size(131, 20);
            this.armstrongLbl.TabIndex = 0;
            this.armstrongLbl.Text = "Armstrong Sayı";
            // 
            // ustSinirTxt
            // 
            this.ustSinirTxt.Location = new System.Drawing.Point(146, 179);
            this.ustSinirTxt.Name = "ustSinirTxt";
            this.ustSinirTxt.Size = new System.Drawing.Size(120, 20);
            this.ustSinirTxt.TabIndex = 9;
            // 
            // altSinirTxt
            // 
            this.altSinirTxt.Location = new System.Drawing.Point(15, 179);
            this.altSinirTxt.Name = "altSinirTxt";
            this.altSinirTxt.Size = new System.Drawing.Size(120, 20);
            this.altSinirTxt.TabIndex = 9;
            // 
            // armstrongLst
            // 
            this.armstrongLst.FormattingEnabled = true;
            this.armstrongLst.Location = new System.Drawing.Point(15, 205);
            this.armstrongLst.Name = "armstrongLst";
            this.armstrongLst.Size = new System.Drawing.Size(168, 186);
            this.armstrongLst.TabIndex = 8;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(205)))), ((int)(((byte)(219)))));
            this.panel7.Controls.Add(this.label9);
            this.panel7.Location = new System.Drawing.Point(146, 126);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(120, 46);
            this.panel7.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(26, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Üst Sınır";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(205)))), ((int)(((byte)(219)))));
            this.panel6.Controls.Add(this.label7);
            this.panel6.Location = new System.Drawing.Point(15, 126);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(120, 46);
            this.panel6.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(21, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Alt Sınır";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(205)))), ((int)(((byte)(219)))));
            this.panel8.Controls.Add(this.label8);
            this.panel8.Location = new System.Drawing.Point(15, 77);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(251, 31);
            this.panel8.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(95, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "- SAYI -";
            // 
            // bulBtn
            // 
            this.bulBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.bulBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bulBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bulBtn.Location = new System.Drawing.Point(183, 356);
            this.bulBtn.Name = "bulBtn";
            this.bulBtn.Size = new System.Drawing.Size(83, 26);
            this.bulBtn.TabIndex = 0;
            this.bulBtn.Text = "Bul";
            this.bulBtn.UseVisualStyleBackColor = false;
            this.bulBtn.Click += new System.EventHandler(this.bul_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(205)))), ((int)(((byte)(219)))));
            this.panel5.Controls.Add(this.label6);
            this.panel5.Location = new System.Drawing.Point(15, 10);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(251, 46);
            this.panel5.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(95, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "SORU 2:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(639, 548);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.parametrelerGroupbox);
            this.Controls.Add(this.soru1Panel);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.mayinTarlasiPnl);
            this.Controls.Add(this.baslaBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mayinSayisiNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sureNUD)).EndInit();
            this.soru1Panel.ResumeLayout(false);
            this.soru1Panel.PerformLayout();
            this.parametrelerGroupbox.ResumeLayout(false);
            this.parametrelerGroupbox.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label süreLbl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label armstrongLbl;
        public System.Windows.Forms.ListBox listBox1;
        public System.Windows.Forms.NumericUpDown mayinSayisiNUD;
        public System.Windows.Forms.NumericUpDown sureNUD;
        public System.Windows.Forms.Button baslaBtn;
        public System.Windows.Forms.Panel mayinTarlasiPnl;
        public System.Windows.Forms.Panel soru1Panel;
        public System.Windows.Forms.GroupBox parametrelerGroupbox;
        public System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.ListBox armstrongLst;
        public System.Windows.Forms.TextBox ustSinirTxt;
        public System.Windows.Forms.TextBox altSinirTxt;
        public System.Windows.Forms.Button bulBtn;
        public System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Label label4;
    }
}

