using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.XtraEditors;

namespace TheDrivingLicencesClient.BLL
{
    public static class FormBLL
    {
        public static string getMultipleAns(List<CheckButton> listCheckButton)
        {
            var temp = string.Empty;
            foreach (CheckButton item in listCheckButton)
            {
                if (item.Checked)
                {
                    temp += item.Text;
                }
            }
            return temp;
        }

        public static void setMultipleAns(List<CheckButton> listCheckButton, string ans)
        {
            resetCheckButtom(listCheckButton);
            foreach (CheckButton item in listCheckButton)
            {
                if (ans.Contains(item.Text))
                {
                    item.Checked = true;
                }
                else
                {
                    item.Checked = false;
                }
            }
        }

        public static string addAnsToListAns(List<CheckButton> listCheckButton, string a)
        {
            var temp = a;

            foreach (CheckButton item in listCheckButton)
            {
                if (item.Checked)
                {
                    temp += item.Text;
                }
            }
            return temp;
        }

        public static void resetCheckButtom(List<CheckButton> listCheckButton)
        {
            foreach (CheckButton item in listCheckButton)
            {
                item.Checked = false;
            }
        }
    }
}
