using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QAinBraam.Logic
{
    public class RatesCalculator
    {
        public int calculateCreditScore(double amountOwed, int paymentHistoryScore, int creditMixScore, int newCreditScore, int creditHistoryLengthScore)
        {
            int amountOwedPercentage = 0;
            if (amountOwed >= 1000000.00)
            {
                amountOwedPercentage = 0;
            }
            else
            {
                var allowableOutstanding = 1000000 - amountOwed;
                amountOwedPercentage = (int)(allowableOutstanding / 1000000 * 0.3 * 100);
            }

            return amountOwedPercentage;
        }
    }
}