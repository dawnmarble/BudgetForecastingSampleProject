using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApplication
{
    public class Income
    {
        public enum PayFrequency { Monthly = 0, Semimonthly = 1, Biweekly = 2, Weekly = 3 };

        public PayFrequency Frequency { get; }
        public decimal Amount { get; }
        public DateTime Date { get; }
        public DateTime Date2 { get; }
        DayOfWeek PayDayOfWeek;

        public Income(decimal amount, PayFrequency frequency, DateTime date)
        {
            Amount = amount;
            Frequency = frequency;
            Date = date;
            Date2 = date;
            PayDayOfWeek = date.DayOfWeek;
            if (date.Day <= 15)
            {
                Date2 = date.AddDays(15);
            } else
            {
                Date = date.AddDays(-15);
            }
        }

        public Income(decimal amount, PayFrequency frequency, DateTime date, DateTime date2)
        {
            Amount = amount;
            Frequency = frequency;
            Date = date;
            Date2 = date2;
            PayDayOfWeek = date.DayOfWeek;
        }

        /// <summary>
        /// Gets a list of Transactions corresponding to pay dates for a given range
        /// </summary>
        /// <param name="start">DateTime representation for the beginning of the date range (inclusive)</param>
        /// <param name="end">DateTime representation for the end of the date range (inclusive)</param>
        /// <returns>List of Transactions</returns>
        public List<Transaction> getTransactions(DateTime start, DateTime end)
        {
            DateTime current;
            DateTime current2;
            //DateTime first = firstDayOfWeekInMonth(date.DayOfWeek, now);
            List<Transaction> payDates = new List<Transaction>();
            switch (Frequency)
            {
                case PayFrequency.Monthly:
                    current = new DateTime(start.Year, start.Month, Date.Day);
                    do
                    {
                        if (current >= start)
                        {
                            payDates.Add(new Transaction(current, Amount));
                        }
                        current = current.AddMonths(1);
                    } while (current < end);
                    break;
                case PayFrequency.Semimonthly:
                    current = new DateTime(start.Year, start.Month, Date.Day);
                    current2 = new DateTime(start.Year, start.Month, Date2.Day);
                    do
                    {
                        if (current >= start)
                        {
                            payDates.Add(new Transaction(current, Amount));
                        }
                        if (current2 <= end)
                        {
                            payDates.Add(new Transaction(current2, Amount));
                        }
                        current = current.AddMonths(1);
                        current2 = current2.AddMonths(1);
                    } while (current2 < end);
                    break;
                case PayFrequency.Biweekly:
                    current = getNextDayOfWeek(PayDayOfWeek, start);
                    if ((current.Subtract(Date).Days / 7) % 2 != 0)
                    {
                        current.AddDays(7);
                    }
                    while (current <= end) {
                        payDates.Add(new Transaction(current, Amount));
                        current = current.AddDays(14);
                    }
                    break;
                case PayFrequency.Weekly:
                    current = getNextDayOfWeek(PayDayOfWeek, start);
                    while (current <= end)
                    {
                        payDates.Add(new Transaction(current, Amount));
                        current = current.AddDays(7);
                    }
                    break;
            }
            return payDates.OrderBy(o => o.Date).ToList();

        }

        /// <summary>
        /// Determines the next DayOfWeek from a specific date.  
        /// </summary>
        /// <param name="day">DayOfWeek to search for</param>
        /// <param name="start">Date (inclusive) to start searching from</param>
        /// <returns>DateTime with the DayOfWeek specified</returns>
        public DateTime getNextDayOfWeek(DayOfWeek day, DateTime start)
        {
            while (start.DayOfWeek != day)
            {
                start = start.AddDays(1);
            }
            return start;
        }

    }
}
