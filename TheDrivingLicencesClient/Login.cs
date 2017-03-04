using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheDrivingLicencesClient
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            panelLogin.Hide();
        }

       

      

        private void Check_click(object sender, EventArgs e)
        {
            this.open.Enabled = true;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.close.Enabled = true;
        }

        private void open_Tick(object sender, EventArgs e)
        {
            panelLogin.Show();
            
            int temp = panelLogin.Location.X;
            for (int x = temp; x >= 320; x -= 10)
            {
                panelLogin.Location = new Point(x, 3);
                Refresh();
                System.Threading.Thread.Sleep(5);
            }
            this.open.Enabled = false;
        }

        private void close_tick(object sender, EventArgs e)
        {


            for (int x = 320; x <= 720; x += 10)
            {
                panelLogin.Location = new Point(x, 3);
                Refresh();
                System.Threading.Thread.Sleep(5);
            }
            panelLogin.Hide();
            this.close.Enabled = false;
        }

        private void closeWindow_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
