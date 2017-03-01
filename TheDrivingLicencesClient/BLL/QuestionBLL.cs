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
    public class QuestionBLL
    {
        /**
         * param name="list"
         * return : trả lại list question đã được random
         */
        public List<Question> getRandomListQ(List<Question> list)
        {
            // code below here 
            return null;
        }

        /**
         *param name="answer" 
         *param name="q"
         *returns trả về true, false kiểm  tra đáp án đùng không
         *example 
         */
        public bool checkAnswer(Question q, string answer)
        {
            //code below here
            return true;
        }

        /**
         * param name="q" câu hỏi
         * returns trả về đáp án kiểu string
         */ 
        public string getAnswer(Question q)
        {
            //code below here
            return null;
        }

        /**
         * param name="answer" : list các câu trả lời đc trọng
         * param name="list" : list các câu hỏi
         */ 
        public Result getResult(List<Question> list, List<string> answer)
        {
            //code below here
            return null;
        }

        /**
         * param name="url" đường truyền từ mạng intenet
         * returns trả về ảnh dạng Image
         */
        public Image getImage(string url)
        {
            MemoryStream msImage;
            WebClient wcImage = new WebClient();
            msImage = new MemoryStream(wcImage.DownloadData("url hình ảnh"));
            return Image.FromStream(msImage);
        }
    }
}
