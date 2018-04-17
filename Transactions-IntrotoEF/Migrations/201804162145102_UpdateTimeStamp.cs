namespace Transactions_IntrotoEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateTimeStamp : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.TransactionsEFs", "TimeStamp", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.TransactionsEFs", "TimeStamp", c => c.String());
        }
    }
}
