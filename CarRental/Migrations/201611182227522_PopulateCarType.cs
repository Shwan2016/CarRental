namespace CarRental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCarType : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO CarModels (Name) VALUES ('Camry')");
            Sql("INSERT INTO CarModels (Name) VALUES ('Corolla')");
            Sql("INSERT INTO CarModels (Name) VALUES ('Land Cruiser')");
            Sql("INSERT INTO CarModels (Name) VALUES ('BMW i8')");
            Sql("INSERT INTO CarModels (Name) VALUES ('Juke')");
            Sql("INSERT INTO CarModels (Name) VALUES ('Camaro')");
        }
        
        public override void Down()
        {
        }
    }
}
