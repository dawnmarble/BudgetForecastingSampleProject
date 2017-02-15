using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApplication
{
    public class Transaction
    {
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }

        public Transaction(DateTime date, decimal amount)
        {
            Date = date;
            Amount = amount;
        }

    }
}
