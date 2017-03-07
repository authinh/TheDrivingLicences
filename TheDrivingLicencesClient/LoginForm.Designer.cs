namespace TheDrivingLicencesClient
{
    partial class LoginForm
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
            this.lMesseger = new System.Windows.Forms.Label();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.bLogin = new System.Windows.Forms.Button();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbUserName = new System.Windows.Forms.TextBox();
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
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lMesseger);
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
            this.splitContainer1.Size = new System.Drawing.Size(569, 399);
            this.splitContainer1.SplitterDistance = 541;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 0;
            // 
            // lMesseger
            // 
            this.lMesseger.AutoSize = true;
            this.lMesseger.ForeColor = System.Drawing.Color.Red;
            this.lMesseger.Location = new System.Drawing.Point(399, 104);
            this.lMesseger.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lMesseger.Name = "lMesseger";
            this.lMesseger.Size = new System.Drawing.Size(0, 13);
            this.lMesseger.TabIndex = 14;
            // 
            // panelLogin
            // 
            this.panelLogin.Controls.Add(this.button3);
            this.panelLogin.Controls.Add(this.bLogin);
            this.panelLogin.Controls.Add(this.tbPassword);
            this.panelLogin.Controls.Add(this.tbUserName);
            this.panelLogin.Controls.Add(this.label9);
            this.panelLogin.Controls.Add(this.label8);
            this.panelLogin.Location = new System.Drawing.Point(525, 6);
            this.panelLogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(222, 393);
            this.panelLogin.TabIndex = 10;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(118, 184);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(77, 27);
            this.button3.TabIndex = 1;
            this.button3.Text = "Trở Lại";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Back_Click);
            // 
            // bLogin
            // 
            this.bLogin.Location = new System.Drawing.Point(36, 184);
            this.bLogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bLogin.Name = "bLogin";
            this.bLogin.Size = new System.Drawing.Size(77, 27);
            this.bLogin.TabIndex = 1;
            this.bLogin.Text = "Đăng Nhập";
            this.bLogin.UseVisualStyleBackColor = true;
            this.bLogin.Click += new System.EventHandler(this.doLogin);
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(36, 118);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(160, 20);
            this.tbPassword.TabIndex = 1;
            this.tbPassword.UseSystemPasswordChar = true;
            // 
            // tbUserName
            // 
            this.tbUserName.Location = new System.Drawing.Point(36, 58);
            this.tbUserName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(160, 20);
            this.tbUserName.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(34, 90);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Password:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(34, 33);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "UserName:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label10);
            this.panel3.Location = new System.Drawing.Point(17, 335);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(303, 63);
            this.panel3.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(67, 20);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Logo ở đây";
            // 
            // bExit
            // 
            this.bExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bExit.Location = new System.Drawing.Point(436, 157);
            this.bExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(84, 31);
            this.bExit.TabIndex = 12;
            this.bExit.Text = "Thoát";
            this.bExit.UseVisualStyleBackColor = false;
            this.bExit.Click += new System.EventHandler(this.closeWindow_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(334, 157);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 31);
            this.button1.TabIndex = 12;
            this.button1.Text = "KT Thông Tin";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Check_click);
            // 
            // tbSoBaoDanh
            // 
            this.tbSoBaoDanh.Location = new System.Drawing.Point(401, 119);
            this.tbSoBaoDanh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbSoBaoDanh.Name = "tbSoBaoDanh";
            this.tbSoBaoDanh.Size = new System.Drawing.Size(120, 20);
            this.tbSoBaoDanh.TabIndex = 11;
            // 
            // cbTitle
            // 
            this.cbTitle.FormattingEnabled = true;
            this.cbTitle.Location = new System.Drawing.Point(401, 82);
            this.cbTitle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbTitle.Name = "cbTitle";
            this.cbTitle.Size = new System.Drawing.Size(120, 21);
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
            this.panel1.Location = new System.Drawing.Point(17, 35);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(294, 266);
            this.panel1.TabIndex = 9;
            // 
            // lAddress
            // 
            this.lAddress.AutoSize = true;
            this.lAddress.Location = new System.Drawing.Point(100, 155);
            this.lAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lAddress.Name = "lAddress";
            this.lAddress.Size = new System.Drawing.Size(0, 13);
            this.lAddress.TabIndex = 1;
            // 
            // lCMND
            // 
            this.lCMND.AutoSize = true;
            this.lCMND.Location = new System.Drawing.Point(100, 124);
            this.lCMND.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lCMND.Name = "lCMND";
            this.lCMND.Size = new System.Drawing.Size(0, 13);
            this.lCMND.TabIndex = 1;
            // 
            // lBrithday
            // 
            this.lBrithday.AutoSize = true;
            this.lBrithday.Location = new System.Drawing.Point(100, 90);
            this.lBrithday.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lBrithday.Name = "lBrithday";
            this.lBrithday.Size = new System.Drawing.Size(0, 13);
            this.lBrithday.TabIndex = 1;
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Location = new System.Drawing.Point(100, 60);
            this.lName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(0, 13);
            this.lName.TabIndex = 1;
            // 
            // lRank
            // 
            this.lRank.AutoSize = true;
            this.lRank.Location = new System.Drawing.Point(100, 26);
            this.lRank.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lRank.Name = "lRank";
            this.lRank.Size = new System.Drawing.Size(0, 13);
            this.lRank.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 26);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Hạng Xe:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 155);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Địa Chỉ:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 124);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Số ĐT:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 60);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Họ Tên:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 90);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ngày Sinh:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(332, 124);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Số báo danh:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(332, 82);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
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
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 399);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "LoginForm";
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
        private System.Windows.Forms.Button bLogin;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbUserName;
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
        private System.Windows.Forms.Label lMesseger;
    }
}