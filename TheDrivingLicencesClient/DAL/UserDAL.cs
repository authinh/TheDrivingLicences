using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheDrivingLicencesClient.DAL
{
    public class UserDAL
    {
        private DataClasses1DataContext db;

        public UserDAL()
        {
            db = new DataClasses1DataContext();
        }
        /**
         *param name="user"
         *param name="user"
         * returns id >=0
         * returns -1 if user pass incorrect
         * returns -2 other error
         */
        public int checkAccount(string user, string pass)
        {
            try {
                int userId = (from table in db.Users
                              where (table.Username.Equals(user) && table.Password.Equals(pass))  
                                select table.UserID).SingleOrDefault();

                if (userId > 0){
                    return userId;
                }
                 else {
                    return -1;
                }
                }
                catch(InvalidOperationException){
                    return -2;
                }
        }

        /**
         * param name="userId"
         * returns info use
         */
        public User getInfoUser(int userId)
        {
            try
            {
                User user = (from table in db.Users
                             where (table.UserID == userId)
                             select table
                                ).SingleOrDefault();

                return user;
            }
            catch (InvalidOperationException)
            {
                return null;
            }

        }

    }
}
