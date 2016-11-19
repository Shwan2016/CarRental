namespace CarRental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlterPropertiesForCar2 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Cars", "CarModelId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Cars", "CarModelId", c => c.Byte(nullable: false));
        }
    }
}
