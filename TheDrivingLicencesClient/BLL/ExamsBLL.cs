using System;
using System.Collections.Generic;
using System.Linq;
using TheDrivingLicencesClient.DAL;

namespace TheDrivingLicencesClient.BLL
{
    public static class ExamsBLL
    {
        public static List<Exam> getListExams()
        {
            var examsDAL = new ExamsDAL();
            return examsDAL.getListExams();
        }

        public static Exam getExamsByID(int examID)
        {
            var examsDAL = new ExamsDAL();
            return examsDAL.getExamsByID(examID);
        }
    }
}
