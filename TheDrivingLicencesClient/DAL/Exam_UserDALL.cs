using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheDrivingLicencesClient.DAL
{
    public class Exam_UserDALL
    {
        private DataClasses1DataContext db;
        public Exam_UserDALL()
        {
            db = new DataClasses1DataContext();
        }
        public bool checkStatusUser(int userID, int examID)
        {
            try
            {
                var check = (from table in db.ExamsUsers
                             where (table.ExamID.Equals(examID) && table.UserID.Equals(userID))
                             select table.Status).Single();
                return check;
            }
            catch
            {
                throw new Exception("the account is not registered for the exam");
            }



        }

       

        public bool checkStatusUser(int userID, int examID, bool status)
        {
            try
            {
                ExamsUser examUser = db.ExamsUsers.Where(s => s.ExamID == examID && s.UserID == userID).Single();
                examUser.Status = status;
                db.SubmitChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool setMark(int result,int userId,int examId)
        {
            try
            {

                ExamsUser examUser = db.ExamsUsers.Where(x => (x.ExamID.Equals(examId) && x.UserID.Equals(userId))).Single();
                examUser.Mark = result;
                db.SubmitChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
            
        }
    }
}
