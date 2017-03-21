using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using TheDrivingLicencesClient.BLL;
using TheDrivingLicencesClient.DAL;
using System.Drawing;
using System.Threading;

namespace TheDrivingLicencesClient
{
    public partial class TestForm : Form
    {
        private Exam exam;
        private User user;
        private List<Question> listQ;
        private int min;
        private List<Button> listButton;
        private List<CheckButton> listCheckButton;
        private List<string> listAns;
        private int index;
        private int totalDone;

        public TestForm()
        {

            exam = ExamsBLL.getExamsByID(1);
            user = UserBLL.getUser(3);
            InitializeComponent();
            GlobalKeyboardHook hook = new GlobalKeyboardHook();
            hook.KeyDown += new KeyEventHandler(hook_KeyDown);
            hook.Hook();
            TopMost = true;

        }

        
        public TestForm(Exam exam, User user)
        {
            this.exam = exam;
            this.user = user;
            InitializeComponent();
            GlobalKeyboardHook hook = new GlobalKeyboardHook();
            hook.KeyDown += new KeyEventHandler(hook_KeyDown);
            hook.Hook();
            TopMost = true;

        }

        private static void hook_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
            e.Handled = true;
        }


        private void TestForm_Load(object sender, EventArgs e)
        {
            Hide();
            labelName.Text = user.FirstName + " " + user.LastName;
            labelInforName.Text = user.FirstName + " " + user.LastName;
            labelInforID.Text = user.UserID.ToString();
            labelInforPhone.Text = user.Mobile;
            labelInforBirth.Text = user.Birthday.ToShortDateString();
            labelInforAdress.Text = user.Address;
            labelTitle.Text = exam.ExamTitle;

            min = exam.ExamTime.Minutes;
            lTime.Text = min.ToString();
            min *= 60;
            
            listQ = QuestionBLL.getRandomListQ(exam.ExamID);
            totalDone = listQ.Count;
            labelNotSelected.Text = totalDone.ToString();
            listAns = new List<string>();
            iSImageQuestion.CurrentImageIndexChanged += iSImageQuestion_CurrentImageIndexChanged;
            foreach (Question item in listQ)
            {
                try
                {
                    iSImageQuestion.Images.Add(QuestionBLL.getImage(item.QuestionImage));
                }
                catch (Exception)
                {

                    MessageBox.Show("internet is not connected");
                    System.Threading.Thread.Sleep(3000);
                    this.Close();
                }

                listAns.Add(string.Empty);
            }
            listButton = new List<Button>();
            for (var i = 1; i <= listQ.Count; i++)
            {
                var b = new Button();
                b.Text = i + string.Empty;
                b.Size = new Size(60, 60);
                b.BackColor = Color.WhiteSmoke;

                listButton.Add(b);
                b.Click += selectQuestion_Click;
                fLpListNumber.Controls.Add(b);

            }

            listCheckButton = new List<CheckButton>();
            listCheckButton.Add(cbAnsA);
            listCheckButton.Add(cbAnsB);
            listCheckButton.Add(cbAnsC);
            listCheckButton.Add(cbAnsD);
            label17.Text = listQ.Count.ToString();
            Show();

        }

        private void iSImageQuestion_CurrentImageIndexChanged(object sender, DevExpress.XtraEditors.Controls.ImageSliderCurrentImageIndexChangedEventArgs e)
        {
            var staus = iSImageQuestion.CurrentImageIndex;
            lStatus.Text = (staus + 1).ToString();
        }







        private void doCountdown(object sender, EventArgs e)
        {
            var ts = TimeSpan.FromSeconds(min--);


            labelCountTime.Text = ts.ToString(@"hh\:mm\:ss");
            Refresh();

            if (min < 0)
            {
                ResultForm rf = new ResultForm(listQ, listAns, user, exam);
                rf.FormClosed += rf_FormClosed;
                rf.Show();
                Hide();
                countdown.Enabled = false;
            }
        }

        private void selectQuestion_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;

            index = int.Parse(button.Text);
            lStatus.Text = index.ToString();
        }

        private void lStatus_TextChanged(object sender, EventArgs e)
        {
            var staus = int.Parse(((Label)sender).Text) - 1;

            iSImageQuestion.CurrentImageIndex = staus;

            FormBLL.resetCheckButtom(listCheckButton);

            FormBLL.setMultipleAns(listCheckButton, listAns[staus]);
        }



        private void doSelectAns_Click(object sender, MouseEventArgs e)
        {
            var staus = int.Parse(lStatus.Text) - 1;
            var cb = (CheckButton)sender;
            var ans = cb.Text;
            if (cb.Checked)
            {
                listAns[staus] = listAns[staus].Replace(ans, string.Empty);
            }
            else
            {
                listAns[staus] += ans;
            }
            if (!listAns[staus].Equals(string.Empty))
            {
                listButton[staus].BackColor = Color.Lime;
            }
            else
            {
                listButton[staus].BackColor = Color.WhiteSmoke;
            }
            var count = 0;

            foreach (string item in listAns)
            {
                if (item.Length > 0)
                {
                    count++;
                }
            }
            labelSelected.Text = count.ToString();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            var staus = int.Parse(lStatus.Text);
            if (staus == listQ.Count)
            {
                staus = 1;
            }
            else
            {
                staus++;
            }
            lStatus.Text = staus.ToString();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            var staus = int.Parse(lStatus.Text);
            if (staus == 1)
            {
                staus = listQ.Count;
            }
            else
            {
                staus--;
            }
            lStatus.Text = staus.ToString();
        }

        private void checkBoxChose_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked)
            {
                buttonSubmit.Enabled = true;
            }
            else
            {
                buttonSubmit.Enabled = false;
            }
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            ResultForm rf = new ResultForm(listQ, listAns, user, exam);
            rf.FormClosed +=rf_FormClosed;
            rf.Show();     
            
            Hide();
        }

        private void rf_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
