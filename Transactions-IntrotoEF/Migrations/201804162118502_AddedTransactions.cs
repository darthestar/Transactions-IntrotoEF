namespace Transactions_IntrotoEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedTransactions : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TransactionsEFs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TimeStamp = c.String(),
                        Action = c.String(),
                        AccountNumber = c.String(),
                        AmountChanged = c.String(),
                        newAmount = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TransactionsEFs");
        }
    }
}
