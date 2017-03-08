using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheDrivingLicencesClient.DAL;

namespace TheDrivingLicencesClient.BLL
{
    public static class ExamsBLL
    {


        public static List<Exam> getListExams()
        {
            ExamsDAL examsDAL = new ExamsDAL();
            return examsDAL.getListExams();
        }

        public static Exam getExamsByID(int examID)
        {
            ExamsDAL examsDAL = new ExamsDAL();
            return examsDAL.getExamsByID(examID);
        }
        
        
    }
}
