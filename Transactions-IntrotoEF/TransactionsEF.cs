using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransactionsIntrotoEF
{
    public class TransactionsEF
    {
        public int Id { get; set; }
        public DateTime TimeStamp { get; set; }
        public string Action { get; set; }
        public string AccountNumber { get; set; }
        public int AmountChanged { get; set; }
        public int newAmount { get; set; }
    }
}
