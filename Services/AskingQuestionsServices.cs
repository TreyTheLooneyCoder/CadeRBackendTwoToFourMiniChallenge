using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadeRBackendTwoToFour.Services
{
    public class AskingQuestionsServices
    {
        
        public string AskQuestions(string name, string time)
        {
            return $"Hey, your name is {name} and you woke up at {time}";
        }
    }
}