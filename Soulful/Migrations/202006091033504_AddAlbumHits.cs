namespace Soulful.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAlbumHits : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Album", "Hits", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Album", "Hits");
        }
    }
}
