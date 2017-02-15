using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestApplication;
using System.Collections.Generic;
using System.Collections;

namespace UnitTests
{
    [TestClass]
    public class IncomeTests
    {
        [TestMethod]
        public void nextDayOfWeek()
        {
            Income income = new Income(1000, Income.PayFrequency.Weekly, new DateTime(2017,1,1)); //Sunday, January 1, 2017
            Assert.AreEqual(new DateTime(2017,1,6), income.getNextDayOfWeek(DayOfWeek.Friday, new DateTime(2017, 1, 1)));
        }
        [TestMethod]
        public void monthlyPaymentSemiMonthly()
        {
            Income income = new Income(1000, Income.PayFrequency.Semimonthly, new DateTime(2017,1,10));
            DateTime start = new DateTime(2017, 2, 1);
            DateTime end = new DateTime(2017, 3, 1);
            List<Transaction> expected = new List<Transaction>();
            expected.Add(new Transaction(new DateTime(2017, 2, 10), 1000));
            expected.Add(new Transaction(new DateTime(2017, 2, 25), 1000));
            CollectionAssert.AreEqual(expected, income.getTransactions(start, end), Comparer);
        }
        [TestMethod]
        public void monthlyPaymentMonthly()
        {
            Income income = new Income(1000, Income.PayFrequency.Monthly, new DateTime(2017, 1, 10));
            DateTime start = new DateTime(2017, 2, 1);
            DateTime end = new DateTime(2017, 3, 1);
            List<Transaction> expected = new List<Transaction>();
            expected.Add(new Transaction(new DateTime(2017, 2, 10), 1000));
            CollectionAssert.AreEqual(expected, income.getTransactions(start, end), Comparer);

        }
        [TestMethod]
        public void monthlyPaymentWeekly()
        {
            Income income = new Income(1000, Income.PayFrequency.Weekly, new DateTime(2017, 1, 10));
            DateTime start = new DateTime(2017, 2, 1);
            DateTime end = new DateTime(2017, 3, 1);
            List<Transaction> expected = new List<Transaction>();
            expected.Add(new Transaction(new DateTime(2017, 2, 7), 1000));
            expected.Add(new Transaction(new DateTime(2017, 2, 14), 1000));
            expected.Add(new Transaction(new DateTime(2017, 2, 21), 1000));
            expected.Add(new Transaction(new DateTime(2017, 2, 28), 1000));
            CollectionAssert.AreEqual(expected, income.getTransactions(start, end), Comparer);
        }
        [TestMethod]
        public void monthlyPaymentBiWeekly()
        {
            Income income = new Income(1000, Income.PayFrequency.Biweekly, new DateTime(2017, 1, 10));
            DateTime start = new DateTime(2017, 2, 1);
            DateTime end = new DateTime(2017, 3, 1);
            List<Transaction> expected = new List<Transaction>();
            expected.Add(new Transaction(new DateTime(2017, 2, 7), 1000));
            expected.Add(new Transaction(new DateTime(2017, 2, 21), 1000));
            CollectionAssert.AreEqual(expected, income.getTransactions(start, end), Comparer);
        }

        public class CompareTransactionsByDate : IComparer
        {
            int IComparer.Compare(Object x, Object y) {
                Transaction tx = (Transaction)x;
                Transaction ty = (Transaction)y;
                return DateTime.Compare(tx.Date, ty.Date);
            }
        }

        public CompareTransactionsByDate Comparer = new CompareTransactionsByDate();
    }
}
