using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheDrivingLicencesClient.BLL;
using TheDrivingLicencesClient.DAL;
using DevExpress.XtraWaitForm;

namespace TheDrivingLicencesClient
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            load();
        }

        public void load()
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            panelLogin.Hide();
            // load data cbtitle
           
            cbTitle.DataSource = (List<Exam>)ExamsBLL.getListExams();
            cbTitle.DisplayMember = "ExamTitle";
        }




        private void loadInfo(User user)
        {
            lRank.Text = "A1";
            lName.Text = user.FirstName + " " + user.LastName;
            lBrithday.Text = user.Birthday.ToShortDateString();
            lCMND.Text = user.Mobile;
            lAddress.Text = user.Address;

        }
        private void Check_click(object sender, EventArgs e)
        {
            lMesseger.Text = "";
            try
            {
                int userID = int.Parse(tbSoBaoDanh.Text);
                User user = UserBLL.getUser(userID);
                loadInfo(user);
            }
            catch (FormatException)
            {
                lMesseger.Text = "phải lớn hơn hoặc bằng 0";
                return;
            }
            catch (NullReferenceException)
            {
                lMesseger.Text = "số báo danh không tồn tại";
                return;
            }
            catch (Exception)
            {
                MessageBox.Show("something wrong");
                return;
            }

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

        private void doLogin(object sender, EventArgs e)
        {
            string username = tbUserName.Text;
            string pass = tbPassword.Text;
            int userId= UserBLL.checkAccount(username, pass);
            if (userId != int.Parse(tbSoBaoDanh.Text))
            {
                MessageBox.Show("sai tài khoản hoặc mật khẩu");
            }
            else
            {
                new WaitForm1().Show();
            }               

        }
    }
}
