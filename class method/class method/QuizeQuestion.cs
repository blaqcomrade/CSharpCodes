using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_method
{
    internal class QuizeQuestion
    {
        public string Question { get; set; }

        public string optionA { get; set; }

        public string optionB { get; set; }

        public string optionC { get; set; }

        public string optionD { get; set; }

        public string Answer { get; set; }

        public QuizeQuestion(string quest, string optA, string optB, string optC, string optD, string Ans)
        {
            Question = quest;
            optionA = optA;
            optionB = optB;
            optionC = optC;
            optionD = optD;
            Answer = Ans;
        }
        public QuizeQuestion( )
        { 
        }
    }
}
