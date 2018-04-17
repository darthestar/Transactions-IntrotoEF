using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace TransactionsIntrotoEF.Data
{
    public class DataContext : DbContext
    {
        public DataContext() : base("name=DefaultConnection")
        {

        }

        public DbSet<TransactionsEF> Transactions { get; set; }
    }
}
