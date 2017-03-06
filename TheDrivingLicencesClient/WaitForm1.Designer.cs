namespace TheDrivingLicencesClient
{
    partial class WaitForm1
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
            this.progressPanel1 = new DevExpress.XtraWaitForm.ProgressPanel();
            this.waitPanel = new System.Windows.Forms.TableLayoutPanel();
            this.waitPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // progressPanel1
            // 
            this.progressPanel1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.progressPanel1.Appearance.Options.UseBackColor = true;
            this.progressPanel1.AppearanceCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.progressPanel1.AppearanceCaption.Options.UseFont = true;
            this.progressPanel1.AppearanceDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.progressPanel1.AppearanceDescription.Options.UseFont = true;
            this.progressPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressPanel1.ImageHorzOffset = 20;
            this.progressPanel1.Location = new System.Drawing.Point(0, 21);
            this.progressPanel1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D;
            this.progressPanel1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.progressPanel1.Margin = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.progressPanel1.Name = "progressPanel1";
            this.progressPanel1.Size = new System.Drawing.Size(328, 48);
            this.progressPanel1.TabIndex = 0;
            this.progressPanel1.Text = "progressPanel1";
            // 
            // waitPanel
            // 
            this.waitPanel.AutoSize = true;
            this.waitPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.waitPanel.BackColor = System.Drawing.Color.Transparent;
            this.waitPanel.ColumnCount = 1;
            this.waitPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.waitPanel.Controls.Add(this.progressPanel1, 0, 0);
            this.waitPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.waitPanel.Location = new System.Drawing.Point(0, 0);
            this.waitPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.waitPanel.MaximumSize = new System.Drawing.Size(328, 300);
            this.waitPanel.Name = "waitPanel";
            this.waitPanel.Padding = new System.Windows.Forms.Padding(0, 17, 0, 17);
            this.waitPanel.RowCount = 1;
            this.waitPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.waitPanel.Size = new System.Drawing.Size(328, 90);
            this.waitPanel.TabIndex = 1;
            // 
            // WaitForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(328, 90);
            this.Controls.Add(this.waitPanel);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "WaitForm1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.waitPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraWaitForm.ProgressPanel progressPanel1;
        private System.Windows.Forms.TableLayoutPanel waitPanel;
    }
}
