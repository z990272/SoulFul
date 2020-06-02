namespace Soulful.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DelNews : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.News", "Singer_id", "dbo.Singer");
            DropIndex("dbo.News", new[] { "Singer_id" });
            DropTable("dbo.News");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.News",
                c => new
                    {
                        News_id = c.Int(nullable: false, identity: true),
                        Singer_id = c.Int(nullable: false),
                        About = c.String(nullable: false),
                        Pic = c.String(nullable: false, maxLength: 64),
                        News_title = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.News_id);
            
            CreateIndex("dbo.News", "Singer_id");
            AddForeignKey("dbo.News", "Singer_id", "dbo.Singer", "Singer_id", cascadeDelete: true);
        }
    }
}
