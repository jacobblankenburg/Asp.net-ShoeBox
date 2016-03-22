using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoeBox.Models
{
    public class Survey
    {
        public int ID { get; set; }

        public string question1Score { get; set; }
        public string question2Score { get; set; }
        public string question3Score { get; set; }
        public int questionScore { get; set; }
        public int totalScore { get; set; }
    }
}