namespace CarRental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddChangesToPropertiesOfCar : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Cars", "CarModel_Id", "dbo.CarModels");
            DropIndex("dbo.Cars", new[] { "CarModel_Id" });
            RenameColumn(table: "dbo.Cars", name: "CarModel_Id", newName: "CarModelId");
            AddColumn("dbo.Cars", "TitleNumber", c => c.Int(nullable: false));
            AddColumn("dbo.Cars", "NumberInStock", c => c.Int(nullable: false));
            AlterColumn("dbo.Cars", "CarModelId", c => c.Int(nullable: false));
            CreateIndex("dbo.Cars", "CarModelId");
            AddForeignKey("dbo.Cars", "CarModelId", "dbo.CarModels", "Id", cascadeDelete: true);
            DropColumn("dbo.Cars", "StockNumber");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Cars", "StockNumber", c => c.Int(nullable: false));
            DropForeignKey("dbo.Cars", "CarModelId", "dbo.CarModels");
            DropIndex("dbo.Cars", new[] { "CarModelId" });
            AlterColumn("dbo.Cars", "CarModelId", c => c.Int());
            DropColumn("dbo.Cars", "NumberInStock");
            DropColumn("dbo.Cars", "TitleNumber");
            RenameColumn(table: "dbo.Cars", name: "CarModelId", newName: "CarModel_Id");
            CreateIndex("dbo.Cars", "CarModel_Id");
            AddForeignKey("dbo.Cars", "CarModel_Id", "dbo.CarModels", "Id");
        }
    }
}
