using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransactionsIntrotoEF.Data;


namespace TransactionsIntrotoEF
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbcontext = new DataContext();

            var transaction1 = new TransactionsEF
            {
                TimeStamp = new DateTime(2018, 03, 23),
                Action = "Deposit",
                AccountNumber = "1555900",
                AmountChanged = 600,
                newAmount = 1600,
            };
            dbcontext.Transactions.Add(transaction1);
            var transaction2 = new TransactionsEF
            {
                TimeStamp = new DateTime(2018, 02, 23),
                Action = "Deposit",
                AccountNumber = "1555900",
                AmountChanged = 3600,
                newAmount = 160300,
            };
            dbcontext.Transactions.Add(transaction2);

            var transaction3 = new TransactionsEF
            {
                TimeStamp = new DateTime(2018, 01, 23),
                Action = "Deposit",
                AccountNumber = "155900",
                AmountChanged = 6100,
                newAmount = 710600,
            };
            dbcontext.Transactions.Add(transaction3);

            var transaction4 = new TransactionsEF
            {
                TimeStamp = new DateTime(2018, 04, 16),
                Action = "Transfer",
                AccountNumber = "555900",
                AmountChanged = 1600,
                newAmount = 110600,
            };
            dbcontext.Transactions.Add(transaction4);

            dbcontext.SaveChanges();

            var currentdate = DateTime.Today;
            var todaysTrans = dbcontext.Transactions.Where(w => w.TimeStamp == currentdate);
            Console.WriteLine("These are today's transactions:");
            foreach (var transaction in todaysTrans)
            {
                Console.WriteLine(transaction.Action);
                Console.WriteLine(transaction.TimeStamp);
                Console.WriteLine("Amount changed: " + transaction.AmountChanged);

            }
            Console.WriteLine("************************");

            Console.WriteLine("Ten most recent:");

            var tenRecent = dbcontext.Transactions.Where(transactions => transactions.AccountNumber == "555900").Take(10);
            foreach (var transaction in tenRecent)
            {
                Console.WriteLine(transaction.Action);
                Console.WriteLine(transaction.AmountChanged);
            }

        }
    }
}
