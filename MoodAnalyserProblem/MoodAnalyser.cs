using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserProblem
{
    public class MoodAnalyser
    {
        public string message;
        public MoodAnalyser(string message)
        {
            this.message = message;
        }

        public string Mood()
        {
            message = message.ToLower();
            if (message.Contains("happy"))
                return "happy";
            else
                return "sad";
        }
    }
}
