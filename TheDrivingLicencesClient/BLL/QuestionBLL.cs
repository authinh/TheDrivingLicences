using System;
using System.Collections.Generic;
using System.Linq;
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
            var questionDAL = new QuestionDAL();
            var listTemp = questionDAL.getListQ(examID);
            
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
            var answersDAL = new AnswersDAL();
            return answersDAL.checkAnswer(q.QuestionID, answer);
        }


        /**
         * param name="answer" : list các câu trả lời đc trọng
         * param name="list" : list các câu hỏi
         * returns kết quả thi 
         */
        public static Result getResult(List<Question> list, List<string> answer)
        {
            Result result = new Result();
            int correctAnswer = 0;
            int choiseAnswer = 0;

            for (int i = 0; i < list.Count; i++)
            {
                if (!String.IsNullOrEmpty(answer[i])) choiseAnswer++;
                if (checkAnswer(list[i], answer[i]))
                {
                    correctAnswer++;
                }
            }

            result.totalOfQuestion = list.Count;
            result.numberOfCorrect = correctAnswer;
            result.selectQuestion = choiseAnswer;

            return result;
        }

        /**
         * param name="url" đường truyền từ mạng intenet
         * returns trả về ảnh dạng Image
         */
        public static Image getImage(string url)
        {
            MemoryStream msImage;
            var wcImage = new WebClient();
            msImage = new MemoryStream(wcImage.DownloadData(@"http://dev.anhdung.net/PRN292/" + url));
            return Image.FromStream(msImage);
        }
    }
}
