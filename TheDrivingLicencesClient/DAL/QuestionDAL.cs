using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheDrivingLicencesClient.DAL
{
    public class QuestionDAL
    {
        private DataClasses1DataContext db;

        public QuestionDAL()
        {
            db = new DataClasses1DataContext();
        }

        public List<Question> getListQ(int examID)
        {
            var listQuestion = (from t1 in db.ExamsQuestions
                               join t2 in db.Questions on t1.QuestionID equals t2.QuestionID
                               where t1.ExamID == examID

                               select t2

                                    ).OrderBy(x => x.QuestionID).Take(50).ToList<Question>();
           
            foreach (var item in listQuestion)
            {
                Console.WriteLine(item.QuestionID);
            }
            return (List<Question>)listQuestion;
        }

    }
}
