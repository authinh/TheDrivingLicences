using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheDrivingLicencesClient.DAL;
using System.Security.Cryptography;

namespace TheDrivingLicencesClient.BLL
{
    public static class UserBLL
    {
        public static User getUser(int userID)
        {
            UserDAL userDAL = new UserDAL();
            return userDAL.getInfoUser(userID);
        }

        public static int checkAccount(string username, string pass)
        {
            UserDAL userDAL = new UserDAL();
            ExamsDAL examsDAL = new ExamsDAL();
            //--- phần này chưa xong
            pass = MD5Hash(pass);
            return userDAL.checkAccount(username, pass);
        }

        // tao ma MD5
        public static string MD5Hash(string input)
        {
            StringBuilder hash= new StringBuilder();
            MD5CryptoServiceProvider md5provider = new MD5CryptoServiceProvider();
            byte[] bytes = md5provider.ComputeHash(new UTF8Encoding().GetBytes(input));

            for (int i = 0; i < bytes.Length; i++)
            {
                hash.Append(bytes[i].ToString("x2"));
            }
            return hash.ToString();
        }
    }
}
