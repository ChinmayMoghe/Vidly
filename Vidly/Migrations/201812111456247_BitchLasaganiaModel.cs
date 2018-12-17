namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BitchLasaganiaModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BitchLasagnias",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BitchingCapacity = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.BitchLasagnias");
        }
    }
}
