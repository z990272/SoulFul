namespace Soulful.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Test08 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Album", "About", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Album", "About", c => c.String(maxLength: 64));
        }
    }
}
