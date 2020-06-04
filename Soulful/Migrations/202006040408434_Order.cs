namespace Soulful.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Order : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Buy", "Album_id", "dbo.Album");
            DropForeignKey("dbo.Buy", "AspNetUsers_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Buy", new[] { "Album_id" });
            DropIndex("dbo.Buy", new[] { "AspNetUsers_Id" });
            CreateTable(
                "dbo.Order",
                c => new
                    {
                        Order_id = c.Int(nullable: false, identity: true),
                        Album_id = c.Int(nullable: false),
                        User_id = c.String(nullable: false, maxLength: 128),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Count = c.Int(nullable: false),
                        Datetime = c.DateTime(nullable: false),
                        Fedex = c.String(nullable: false, maxLength: 50),
                        Credit_card = c.String(nullable: false, maxLength: 20),
                        AspNetUsers_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Order_id)
                .ForeignKey("dbo.Album", t => t.Album_id, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.AspNetUsers_Id)
                .Index(t => t.Album_id)
                .Index(t => t.AspNetUsers_Id);
            
            DropTable("dbo.Buy");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Buy",
                c => new
                    {
                        Buy_id = c.Int(nullable: false, identity: true),
                        Album_id = c.Int(nullable: false),
                        User_id = c.String(nullable: false, maxLength: 128),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Count = c.Int(nullable: false),
                        Datetime = c.DateTime(nullable: false),
                        Fedex = c.String(nullable: false, maxLength: 50),
                        Credit_card = c.String(nullable: false, maxLength: 20),
                        AspNetUsers_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Buy_id);
            
            DropForeignKey("dbo.Order", "AspNetUsers_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Order", "Album_id", "dbo.Album");
            DropIndex("dbo.Order", new[] { "AspNetUsers_Id" });
            DropIndex("dbo.Order", new[] { "Album_id" });
            DropTable("dbo.Order");
            CreateIndex("dbo.Buy", "AspNetUsers_Id");
            CreateIndex("dbo.Buy", "Album_id");
            AddForeignKey("dbo.Buy", "AspNetUsers_Id", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.Buy", "Album_id", "dbo.Album", "Album_id", cascadeDelete: true);
        }
    }
}
