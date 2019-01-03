namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMoviesTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MOVIES(Name,Genre_Id)VALUES('The Machinist',5)");
            Sql("INSERT INTO MOVIES(Name,Genre_Id)VALUES('Shawshank Redemption',5)");
            Sql("INSERT INTO MOVIES(Name,Genre_Id)VALUES('Die Hard 4.0',2)");
            Sql("INSERT INTO MOVIES(Name,Genre_Id)VALUES('Toy Story',3)");
            Sql("INSERT INTO MOVIES(Name,Genre_Id)VALUES('Hangover',1)");
            Sql("INSERT INTO MOVIES(Name,Genre_Id)VALUES('Insidious',4)");
        }
        
        public override void Down()
        {
        }
    }
}
