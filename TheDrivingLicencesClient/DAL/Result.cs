using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheDrivingLicencesClient.DAL
{
    public class Result
    {
        public int totalOfQuestion { get; set; }
        public int selectQuestion { get; set; }
        public int numberOfCorrect { get; set; }

        public Result()
        {

        }
        public Result(int totalOfQuestion, int selectQuestion, int numberOfCorrect)
        {
            this.totalOfQuestion = totalOfQuestion;
            this.selectQuestion = selectQuestion;
            this.numberOfCorrect = numberOfCorrect;
        }

        

        
    }
}
