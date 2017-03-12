using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using TheDrivingLicencesClient.BLL;
using TheDrivingLicencesClient.DAL;

namespace TheDrivingLicencesClient
{
    public partial class LoginForm : Form
    {
        private User user;
        public LoginForm()
        {
            InitializeComponent();
            load();

        }

        public void load()
        {
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            panelLogin.Hide();


            cbTitle.DataSource = (List<Exam>)ExamsBLL.getListExams();
            cbTitle.DisplayMember = "ExamTitle";
            cbTitle.SelectionStart = 0;
        }




        private void loadInfo(User user)
        {
            this.user = user;
            lRank.Text = "A1";
            lName.Text = user.FirstName + " " + user.LastName;
            lBrithday.Text = user.Birthday.ToShortDateString();
            lCMND.Text = user.Mobile;
            lAddress.Text = user.Address;
        }
        private void Check_click(object sender, EventArgs e)
        {
            lMesseger.Text = string.Empty;
            try
            {
                var userID = int.Parse(tbSoBaoDanh.Text);
                var user = UserBLL.getUser(userID);
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

            open.Enabled = true;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            close.Enabled = true;
        }

        private void open_Tick(object sender, EventArgs e)
        {
            panelLogin.Show();

            var temp = panelLogin.Location.X;
            for (var x = temp; x >= 320; x -= 10)
            {
                panelLogin.Location = new Point(x, 3);
                Refresh();
                System.Threading.Thread.Sleep(5);
            }
            open.Enabled = false;
        }

        private void close_tick(object sender, EventArgs e)
        {
            for (var x = 320; x <= 720; x += 10)
            {
                panelLogin.Location = new Point(x, 3);
                Refresh();
                System.Threading.Thread.Sleep(5);
            }
            panelLogin.Hide();
            close.Enabled = false;
        }

        private void closeWindow_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void doLogin(object sender, EventArgs e)
        {
            var username = tbUserName.Text;
            var pass = tbPassword.Text;
            var userId = UserBLL.checkAccount(username, pass);
            if (userId != int.Parse(tbSoBaoDanh.Text))
            {
                MessageBox.Show("sai tài khoản hoặc mật khẩu");
            }
            else
            {

                Exam exam = ((Exam)cbTitle.SelectedValue);
                try
                {
                    if (Exam_UserBLL.checkStatusUser(userId, exam.ExamID))
                    {
                        Exam_UserBLL.setStatusUser(userId, exam.ExamID, true);
                        new TestForm(exam, user).Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("tài khoản đã thi không vào đc");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("tài khoản chưa đc đăng ký");
                }


            }
        }
    }
}
