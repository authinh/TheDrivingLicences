using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheDrivingLicencesClient.DAL;
namespace TheDrivingLicencesClient.BLL
{
    public static class Exam_UserBLL
    {
        public static bool checkStatusUser(int userID,int examID){
            DAL.Exam_UserDALL exam = new DAL.Exam_UserDALL();
            return !exam.checkStatusUser(userID,examID);
        }
        public static bool setStatusUser( int userID, int examID,bool status)
        {
            DAL.Exam_UserDALL exam_UserBLL = new DAL.Exam_UserDALL();

            return exam_UserBLL.checkStatusUser(userID,examID,status);
        }

        

        internal static bool setMark(int mark, int p1, int p2)
        {
            Exam_UserDALL exam_UserDAL = new Exam_UserDALL();
            return exam_UserDAL.setMark(mark,p1,p2);
        }
    }
}
