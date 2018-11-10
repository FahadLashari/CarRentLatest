namespace Carrent.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CarAvail : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CarInfoes", "IsAvailable", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.CarInfoes", "IsAvailable");
        }
    }
}
