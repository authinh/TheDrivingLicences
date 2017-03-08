using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace TheDrivingLicencesClient.BLL
{
    public static class FormBLL
    {
        public static string getMultipleAns(List<CheckButton> listCheckButton)
        {
            string temp = "";
            foreach (CheckButton item in listCheckButton)
            {
                if (item.Checked)
                {
                    temp += item.Text;
                }
            }
            return temp;
        }

        public static void setMultipleAns(List<CheckButton> listCheckButton,string ans)
        {
            //------sau lam tiep
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
