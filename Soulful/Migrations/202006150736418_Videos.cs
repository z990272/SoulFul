namespace Soulful.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Videos : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Album", "Video", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Album", "Video");
        }
    }
}
