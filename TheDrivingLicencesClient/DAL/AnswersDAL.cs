﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace TheDrivingLicencesClient.DAL
{
    public class AnswersDAL
    {
        private DataClasses1DataContext db;

        public AnswersDAL()
        {
            db = new DataClasses1DataContext();
        }
        /**
         * param name="QuestionID"
         * param name="ans" là chuỗi các đáp án đúng
         * một câu hỏi có nhiều đáp án đúng
         * returns true false
         */
        public bool checkAnswer(int QuestionID, string ans)
        {
            try
            {
                int count = 0;
                var listAnswer = from table in db.Answers
                                 where table.QuestionID == QuestionID
                                 select table.AnswerTrue;
                //if (listAnswer.Sum()== ans.Length) return false;
                foreach (int answers in listAnswer)
                {
                    count++;
                    if (!ans.Contains(answers.ToString()))
                    {
                        return false;
                    }
                }
                if (count != ans.Length) return false;
                return true;
            }
            catch (Exception)
            {

                return false;
            }

        }
    }
}
