namespace CarRental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlterPropertiesForCar : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Cars", "Color", c => c.String());
            AlterColumn("dbo.Cars", "Year", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Cars", "Year", c => c.Byte(nullable: false));
            AlterColumn("dbo.Cars", "Color", c => c.Short(nullable: false));
        }
    }
}
