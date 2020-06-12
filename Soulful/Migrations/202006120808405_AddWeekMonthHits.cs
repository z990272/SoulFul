namespace Soulful.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddWeekMonthHits : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Album", "WeekHits", c => c.Int(nullable: false));
            AddColumn("dbo.Album", "MonthHits", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Album", "MonthHits");
            DropColumn("dbo.Album", "WeekHits");
        }
    }
}
