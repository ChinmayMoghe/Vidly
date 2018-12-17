namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovalofBitchLasagania : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.BitchLasagnias");
        }
        
        public override void Down()
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
    }
}
