using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using TheDrivingLicencesClient.BLL;
using TheDrivingLicencesClient.DAL;

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
        private int index;
        //tong so cau da chon
        private int totalDone;
        public TestForm()
        {
            this.exam = ExamsBLL.getExamsByID(1);
            this.user = UserBLL.getUser(3);
            InitializeComponent();
        }

        public TestForm(Exam exam, User user)
        {
            this.exam = exam;
            this.user = user;
            InitializeComponent();

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        // load giao diện
        private void TestForm_Load(object sender, EventArgs e)
        {
            index = 0;
            
            // load user info
            this.Hide();
            labelName.Text = user.FirstName + " " + user.LastName;
            labelInforName.Text = user.FirstName + " " + user.LastName;
            labelInforID.Text = user.UserID.ToString();
            labelInforPhone.Text = user.Mobile;
            labelInforBirth.Text = user.Birthday.ToShortDateString();
            labelInforAdress.Text = user.Address;
            labelTitle.Text = exam.ExamTitle;
            // set min
            this.min = exam.ExamTime.Minutes;
            lTime.Text = min.ToString();
            this.min *= 60;
            // load anh question
            listQ = QuestionBLL.getRandomListQ(exam.ExamID);
            totalDone = listQ.Count;
            labelNotSelected.Text = totalDone.ToString();
            foreach (Question item in listQ)
            {
                //iSImageQuestion.Images.Add(QuestionBLL.getImage(item.QuestionImage));
            }
           listButton = new List<Button>();
            for (int i = 1; i <= listQ.Count; i++)
            {
                Button b = new Button();
                b.Text = i+ "";
                b.Size = new Size(60, 60);
                listButton.Add(b);
                b.Click += selectQuestion_Click;
                fLpListNumber.Controls.Add(b);
            }
            // add chech butto
            listCheckButton.Add(cbAnsA);
            listCheckButton.Add(cbAnsB);
            listCheckButton.Add(cbAnsC);
            listCheckButton.Add(cbAnsD);
                
                
           
            
            this.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {


        }



        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

       

        private void doCountdown(object sender, EventArgs e)
        {

            TimeSpan ts = TimeSpan.FromSeconds(min--);
            
               
                labelCountTime.Text = ts.ToString(@"hh\:mm\:ss");
                Refresh();
            // lam sau
                if (min < 0) this.Close();
            

        }

        private void selectQuestion_Click(object sender, EventArgs e)
        {

            Button button = (Button)sender;
            iSImageQuestion.CurrentImageIndex = int.Parse(button.Text);
            index = int.Parse(button.Text); 
        }
    }
}
