using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TheDrivingLicencesClient.DAL;
using System.Security.Cryptography;

namespace TheDrivingLicencesClient.BLL
{
    public static class UserBLL
    {
        public static User getUser(int userID)
        {
            var userDAL = new UserDAL();
            return userDAL.getInfoUser(userID);
        }

        public static int checkAccount(string username, string pass)
        {
            var userDAL = new UserDAL();
            var examsDAL = new ExamsDAL();

            pass = MD5Hash(pass);
            return userDAL.checkAccount(username, pass);
        }


        public static string MD5Hash(string input)
        {
            var hash = new StringBuilder();
            var md5provider = new MD5CryptoServiceProvider();
            var bytes = md5provider.ComputeHash(new UTF8Encoding().GetBytes(input));

            for (var i = 0; i < bytes.Length; i++)
            {
                hash.Append(bytes[i].ToString("x2"));
            }
            return hash.ToString();
        }
    }
}
