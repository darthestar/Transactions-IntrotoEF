namespace Transactions_IntrotoEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateAccountChanged : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.TransactionsEFs", "AmountChanged", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.TransactionsEFs", "AmountChanged", c => c.String());
        }
    }
}
