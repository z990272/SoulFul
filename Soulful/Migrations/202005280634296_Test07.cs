namespace Soulful.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Test07 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Album", "About", c => c.String(maxLength: 64));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Album", "About", c => c.String(nullable: false, maxLength: 64));
        }
    }
}
