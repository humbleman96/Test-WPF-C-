﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class AnswerData
    {
        private static List<Answer> answers = new List<Answer>();

        public static List<Answer> testAnswers
        {
            get
            {
                testAnswerData();
                return answers;
            }

            set
            {

            }


        }


        private static void testAnswerData()
        {
            answers.Add(new Answer("1"));
            answers.Add(new Answer("2"));
            answers.Add(new Answer("3"));
            answers.Add(new Answer("4"));
        }
    }
}