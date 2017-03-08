using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheDrivingLicencesClient.DAL
{
    public class ExamsDAL
    {
        private DataClasses1DataContext db;

        public ExamsDAL()
        {
            db = new DataClasses1DataContext();
        }
        public List<Exam> getListExams()
        {
            try
            {
                List<Exam> listExams = new List<Exam>();
                var list = from table in db.Exams
                           select table;
                foreach (Exam item in list)
                {

                    listExams.Add(item);
                }
                return listExams;
            }
            catch (InvalidOperationException)
            {
                return null;
            }


        }



        public Exam getExamsByID(int examID)
        {
            try
            {
                Exam exam = (from table in db.Exams
                             where table.ExamID == examID
                             select table).SingleOrDefault<Exam>();
                return exam;
            }
            catch (Exception)
            {

                return null;
            }
        }
    }
}
