namespace Muusikapood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class osta2 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Muusikapoeds", "osta");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Muusikapoeds", "osta", c => c.Boolean(nullable: false));
        }
    }
}
