﻿using System;
using System.Collections.Generic;
using System.Linq;

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
        public int checkAccount(string username, string pass)
        {
            try
            {
                var user = (from table in db.Users
                            where (table.Username.Equals(username) )
                            select table).SingleOrDefault();


                if (user.Password.Equals(pass))
                {
                    return user.UserID;
                }
                else
                {
                    return -1;
                }
            }
            catch (InvalidOperationException)
            {
                return -2;
            }
            catch (NullReferenceException)
            {
                return -3;
            }
            catch (Exception)
            {
                return -4;
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
                var user = (from table in db.Users
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
