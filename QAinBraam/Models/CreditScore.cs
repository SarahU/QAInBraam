using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QAinBraam.Models
{
    public class CreditScore
    {
        public string Name { get; set; }
        public int Score { get; set; }
        public double AmountOwed { get; set; }
        public int PaymentHistoryScore { get; set; }
        public int CreditMixScore { get; set; }
        public int NewCreditScore { get; set; }
        public int CreditHistoryLengthScore { get; set; }
    }
}