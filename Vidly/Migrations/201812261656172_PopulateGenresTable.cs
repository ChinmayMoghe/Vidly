namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenresTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO GENRES(Genre) VALUES('Comedy')");
            Sql("INSERT INTO GENRES(Genre) VALUES('Action')");
            Sql("INSERT INTO GENRES(Genre) VALUES('Family')");
            Sql("INSERT INTO GENRES(Genre) VALUES('Horror')");
            Sql("INSERT INTO GENRES(Genre) VALUES('Thriller')");
        }
        
        public override void Down()
        {
        }
    }
}
