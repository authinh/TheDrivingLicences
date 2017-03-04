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

            return ExamsDAL.getListExams();
        }
        
        
    }
}
