using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheDrivingLicencesClient.DAL;
using System.Drawing;
using System.IO;
using System.Net;

namespace TheDrivingLicencesClient.BLL
{
    public static class QuestionBLL
    {
        /**
         * param name="int"
         * return : trả lại list question đã được random
         */
        public static List<Question> getRandomListQ(int examID)
        {
            QuestionDAL questionDAL = new QuestionDAL();
            List<Question> listTemp = questionDAL.getListQ(examID);
            // code below here ---- ramdom cac cau hoi tu list tren

            //-----------------------
            return listTemp;
        }

        /**
         *param name="answer" 
         *param name="q"
         *returns trả về true, false kiểm  tra đáp án đùng không
         *example 
         */
        public static bool checkAnswer(Question q, string answer)
        {
            AnswersDAL answersDAL = new AnswersDAL();
            return answersDAL.checkAnswer(q.QuestionID,answer);
        }
       

        /**
         * param name="answer" : list các câu trả lời đc trọng
         * param name="list" : list các câu hỏi
         * returns kết quả thi 
         */
        public static Result getResult(List<Question> list, List<string> answer)
        {
            //code below here dùng hàm checkAnswer để làm

            return null;
        }

        /**
         * param name="url" đường truyền từ mạng intenet
         * returns trả về ảnh dạng Image
         */
        public static Image getImage(string url)
        {
            MemoryStream msImage;
            WebClient wcImage = new WebClient();
            msImage = new MemoryStream(wcImage.DownloadData(@"http://dev.anhdung.net/PRN292/"+url));
            return Image.FromStream(msImage);
        }
    }
}
