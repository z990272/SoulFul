namespace Soulful.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class stringRecieverPhone : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Order", "RecieverPhone", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Order", "RecieverPhone", c => c.Int(nullable: false));
        }
    }
}
