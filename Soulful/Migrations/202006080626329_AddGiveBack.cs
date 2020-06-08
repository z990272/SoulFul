namespace Soulful.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddGiveBack : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.GiveBacks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        Subject = c.String(nullable: false),
                        Message = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.GiveBacks");
        }
    }
}
