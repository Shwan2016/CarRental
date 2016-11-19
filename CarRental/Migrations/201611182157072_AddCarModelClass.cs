namespace CarRental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCarModelClass : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CarModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Cars", "CarModelId", c => c.Byte(nullable: false));
            AddColumn("dbo.Cars", "CarModel_Id", c => c.Int());
            CreateIndex("dbo.Cars", "CarModel_Id");
            AddForeignKey("dbo.Cars", "CarModel_Id", "dbo.CarModels", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cars", "CarModel_Id", "dbo.CarModels");
            DropIndex("dbo.Cars", new[] { "CarModel_Id" });
            DropColumn("dbo.Cars", "CarModel_Id");
            DropColumn("dbo.Cars", "CarModelId");
            DropTable("dbo.CarModels");
        }
    }
}
