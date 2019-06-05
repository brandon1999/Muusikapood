namespace Muusikapood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class kvaliteedd : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Muusikapoeds", "Kvaliteet", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Muusikapoeds", "Kvaliteet", c => c.String());
        }
    }
}
