namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMembershipName : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MEMBERSHIPTYPES SET NAME ='PAY AS YOU GO' WHERE Id=1");
            Sql("UPDATE MEMBERSHIPTYPES SET NAME ='MONTHLY' WHERE Id=2");
            Sql("UPDATE MEMBERSHIPTYPES SET NAME ='QUARTERLY' WHERE Id=3");
            Sql("UPDATE MEMBERSHIPTYPES SET NAME ='ANNUAL' WHERE Id=4");
        }
        
        public override void Down()
        {
        }
    }
}
