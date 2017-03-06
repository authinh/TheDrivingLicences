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
            var listQuestion = (from table in db.ExamsQuestions
                                where table.ExamID == examID

                                select table).OrderBy(x => x.QuestionID).Take(50);
            //===chua xong
            return null;
        }

    }
}
