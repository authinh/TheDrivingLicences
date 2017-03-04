namespace TheDrivingLicencesClient
{
    partial class Login
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.bExit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tbSoBaoDanh = new System.Windows.Forms.TextBox();
            this.cbTitle = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lAddress = new System.Windows.Forms.Label();
            this.lCMND = new System.Windows.Forms.Label();
            this.lBrithday = new System.Windows.Forms.Label();
            this.lName = new System.Windows.Forms.Label();
            this.lRank = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.open = new System.Windows.Forms.Timer(this.components);
            this.close = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panelLogin.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panelLogin);
            this.splitContainer1.Panel1.Controls.Add(this.panel3);
            this.splitContainer1.Panel1.Controls.Add(this.bExit);
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.tbSoBaoDanh);
            this.splitContainer1.Panel1.Controls.Add(this.cbTitle);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Size = new System.Drawing.Size(759, 491);
            this.splitContainer1.SplitterDistance = 730;
            this.splitContainer1.TabIndex = 0;
            // 
            // panelLogin
            // 
            this.panelLogin.Controls.Add(this.button3);
            this.panelLogin.Controls.Add(this.button2);
            this.panelLogin.Controls.Add(this.textBox3);
            this.panelLogin.Controls.Add(this.textBox2);
            this.panelLogin.Controls.Add(this.label9);
            this.panelLogin.Controls.Add(this.label8);
            this.panelLogin.Location = new System.Drawing.Point(714, 7);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(296, 484);
            this.panelLogin.TabIndex = 10;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(157, 227);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(103, 33);
            this.button3.TabIndex = 1;
            this.button3.Text = "Trở Lại";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Back_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(48, 227);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 33);
            this.button2.TabIndex = 1;
            this.button2.Text = "Đăng Nhập";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(48, 145);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(212, 22);
            this.textBox3.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(48, 72);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(212, 22);
            this.textBox2.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(45, 111);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 17);
            this.label9.TabIndex = 1;
            this.label9.Text = "Password:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(45, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "UserName:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label10);
            this.panel3.Location = new System.Drawing.Point(23, 412);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(404, 77);
            this.panel3.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(89, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "Logo ở đây";
            // 
            // bExit
            // 
            this.bExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bExit.Location = new System.Drawing.Point(582, 193);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(112, 38);
            this.bExit.TabIndex = 12;
            this.bExit.Text = "EXIT";
            this.bExit.UseVisualStyleBackColor = false;
            this.bExit.Click += new System.EventHandler(this.closeWindow_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(446, 193);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 38);
            this.button1.TabIndex = 12;
            this.button1.Text = "Check";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Check_click);
            // 
            // tbSoBaoDanh
            // 
            this.tbSoBaoDanh.Location = new System.Drawing.Point(535, 137);
            this.tbSoBaoDanh.Name = "tbSoBaoDanh";
            this.tbSoBaoDanh.Size = new System.Drawing.Size(159, 22);
            this.tbSoBaoDanh.TabIndex = 11;
            // 
            // cbTitle
            // 
            this.cbTitle.FormattingEnabled = true;
            this.cbTitle.Location = new System.Drawing.Point(535, 101);
            this.cbTitle.Name = "cbTitle";
            this.cbTitle.Size = new System.Drawing.Size(159, 24);
            this.cbTitle.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lAddress);
            this.panel1.Controls.Add(this.lCMND);
            this.panel1.Controls.Add(this.lBrithday);
            this.panel1.Controls.Add(this.lName);
            this.panel1.Controls.Add(this.lRank);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(23, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(390, 326);
            this.panel1.TabIndex = 9;
            // 
            // lAddress
            // 
            this.lAddress.AutoSize = true;
            this.lAddress.Location = new System.Drawing.Point(133, 191);
            this.lAddress.Name = "lAddress";
            this.lAddress.Size = new System.Drawing.Size(54, 17);
            this.lAddress.TabIndex = 1;
            this.lAddress.Text = "label11";
            // 
            // lCMND
            // 
            this.lCMND.AutoSize = true;
            this.lCMND.Location = new System.Drawing.Point(133, 152);
            this.lCMND.Name = "lCMND";
            this.lCMND.Size = new System.Drawing.Size(54, 17);
            this.lCMND.TabIndex = 1;
            this.lCMND.Text = "label11";
            // 
            // lBrithday
            // 
            this.lBrithday.AutoSize = true;
            this.lBrithday.Location = new System.Drawing.Point(133, 111);
            this.lBrithday.Name = "lBrithday";
            this.lBrithday.Size = new System.Drawing.Size(54, 17);
            this.lBrithday.TabIndex = 1;
            this.lBrithday.Text = "label11";
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Location = new System.Drawing.Point(133, 74);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(54, 17);
            this.lName.TabIndex = 1;
            this.lName.Text = "label11";
            // 
            // lRank
            // 
            this.lRank.AutoSize = true;
            this.lRank.Location = new System.Drawing.Point(133, 32);
            this.lRank.Name = "lRank";
            this.lRank.Size = new System.Drawing.Size(54, 17);
            this.lRank.TabIndex = 1;
            this.lRank.Text = "label11";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Hạng Xe:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Địa Chỉ:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Số CMND:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Họ Tên:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ngày Sinh:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(443, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Số báo danh:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(443, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Exam Title:";
            // 
            // open
            // 
            this.open.Tick += new System.EventHandler(this.open_Tick);
            // 
            // close
            // 
            this.close.Tick += new System.EventHandler(this.close_tick);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 491);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Timer open;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbSoBaoDanh;
        private System.Windows.Forms.ComboBox cbTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lAddress;
        private System.Windows.Forms.Label lCMND;
        private System.Windows.Forms.Label lBrithday;
        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.Label lRank;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer close;
        private System.Windows.Forms.Button bExit;
    }
}