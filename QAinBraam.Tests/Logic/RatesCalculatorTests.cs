using Microsoft.VisualStudio.TestTools.UnitTesting;
using QAinBraam.Logic; 

namespace QAinBraam.Tests.Logic
{
    [TestClass]
    public class RatesCalculatorTests
    {
        [TestMethod]
        public void calculateCreditRatingScoreWithAmountOwedBeing1000000()
        {
            RatesCalculator calculator = new RatesCalculator();

            double amountOwed = 1000000;

            int creditScore = calculator.calculateCreditScore(amountOwed, 0, 0, 0, 0);

            Assert.AreEqual(0, creditScore);
        }

        [TestMethod]
        public void calculateCreditRatingScoreWithAmountOwedBeing999999()
        {
            RatesCalculator calculator = new RatesCalculator();

            double amountOwed = 999999;

            int creditScore = calculator.calculateCreditScore(amountOwed, 0, 0, 0, 0);

            Assert.AreEqual(0, creditScore);
        }

        [TestMethod]
        public void calculateCreditRatingScoreWithAmountOwedBeing1000()
        {
            RatesCalculator calculator = new RatesCalculator();

            double amountOwed = 1000;

            int creditScore = calculator.calculateCreditScore(amountOwed, 0, 0, 0, 0);

            Assert.AreEqual(29, creditScore);
        }

        [TestMethod]
        public void calculatePersonsRatingScore()
        {
            //Given person with ID number "8103218230032"
            string id = "8103218230032";

            RatesCalculator calculator = new RatesCalculator();

            double amountOwed = getAmountOwed(id);
            int paymentHistoryScore = getPaymentHistoryScore(id);
            int creditMixScore = getCreditMixScore(id);
            int newCreditScore = getNewCreditScore(id);
            int creditHistoryLengthScore = getCreditHistoryLengthScore(id);

            //Then get their credit score
            int creditScore = calculator.calculateCreditScore(amountOwed, paymentHistoryScore, creditMixScore, newCreditScore, creditHistoryLengthScore);

            Assert.AreEqual(30, creditScore);
        }

        private int getAmountOwed(string id)
        {
            return 0;
        }

        private int getPaymentHistoryScore(string id)
        {
            return 0;
        }

        private int getCreditMixScore(string id)
        {
            return 0;
        }

        private int getNewCreditScore(string id)
        {
            return 0;
        }

        private int getCreditHistoryLengthScore(string id)
        {
            return 0;
        }
    }
}
