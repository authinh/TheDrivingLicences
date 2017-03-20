using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheDrivingLicencesClient.DAL;
using TheDrivingLicencesClient.BLL;

namespace TheDrivingLicencesClient
{
    public partial class ResultForm : Form
    {
        private List<DAL.Question> listQ;
        private List<string> listAns;
        private DAL.User user;
        private DAL.Exam exam;
        public ResultForm()
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            this.listQ = QuestionBLL.getRandomListQ(1);
            exam = ExamsBLL.getExamsByID(1);
            List<String> list = new List<string>();
            list.Add("12");//q1
            list.Add("1");//q2
            list.Add("1");//q3
            list.Add("2");//q4
            list.Add("1");//q5
            list.Add("1");//q6
            list.Add("12");//q7
            for (int i = 0; i < 23; i++)
            {
                list.Add("1234");
            }
            this.listAns = list;
            this.user = db.Users.Where(x => x.UserID == 3).FirstOrDefault();
            InitializeComponent();
        }



        public ResultForm(List<DAL.Question> listQ, List<string> listAns, DAL.User user, DAL.Exam exam)
        {
            // TODO: Complete member initialization
            this.listQ = listQ;
            this.listAns = listAns;
            this.user = user;
            this.exam = exam;
            InitializeComponent();
        }

        private void ResultForm_Load(object sender, EventArgs e)
        {
            lResultID.Text = user.UserID.ToString();
            lResultName.Text = user.LastName + " " + user.FirstName;
            lResultPhone.Text = user.Mobile;
            lResultBirth.Text = user.Birthday.ToShortDateString();
            lResultAdress.Text = user.Address;

            Result result = QuestionBLL.getResult(this.listQ, this.listAns);
            
            chart1.Series["Result"].Points.AddXY("Correct", result.numberOfCorrect);
            chart1.Series["Result"].Points.AddXY("InCorrect", (result.totalOfQuestion - result.numberOfCorrect));
            chart1.Series["Result"].Points[0].Color = Color.LightGreen;
            chart1.Series["Result"].Points[1].Color = Color.Red;

            lCorrect.Text = result.numberOfCorrect.ToString();
            lIncorrect.Text = (result.totalOfQuestion - result.numberOfCorrect).ToString();
            labelResult.Text = result.totalOfQuestion.ToString();

            float mark = ((float)result.numberOfCorrect / (float)result.totalOfQuestion) * 100;
            Exam_UserBLL.setMark((int)mark, user.UserID, exam.ExamID);
            if (mark >= exam.ExamMark)
            {
                labelStatus.Text = "Đã Qua";
                labelStatus.BackColor = Color.LightGreen;
            }
            else
            {
                labelStatus.Text = "Chưa Qua";
                labelStatus.BackColor = Color.Red;
            }
            
            //chart1.Series["inCorrect"].Points.AddXY("Incorrect", 1000);
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
