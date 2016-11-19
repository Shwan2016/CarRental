namespace CarRental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDataAnnotationForCarAndCarModel : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Cars", "Name", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.CarModels", "Name", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.CarModels", "Name", c => c.String());
            AlterColumn("dbo.Cars", "Name", c => c.String());
        }
    }
}
