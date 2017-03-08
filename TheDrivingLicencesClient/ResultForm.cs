using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TheDrivingLicencesClient.BLL;
namespace TheDrivingLicencesClient
{
    public partial class ResultForm : Form
    {
        private List<DAL.Question> listQ;
        private List<string> listAns;

        public ResultForm()
        {
            InitializeComponent();
            

        }
        
        public ResultForm(List<DAL.Question> listQ, List<string> listAns)
        {
            this.listQ = listQ;
            this.listAns = listAns;
        }
    }
}
