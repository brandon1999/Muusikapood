namespace Muusikapood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class osta : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Muusikapoeds", "osta", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Muusikapoeds", "osta");
        }
    }
}
