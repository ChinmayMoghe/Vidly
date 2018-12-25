namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateDOBForCustomer : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET DateOfBirth = CAST('1995-04-11' AS DATETIME) WHERE Id = 1");
            Sql("UPDATE Customers SET DateOfBirth = CAST('1995-03-13' AS DATETIME) WHERE Id = 2");
        }
        
        public override void Down()
        {


        }
    }
}
