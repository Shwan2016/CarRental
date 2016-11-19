namespace CarRental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlterCarModelData : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE CarModels SET Name='Toyota' WHERE Id=1;");
            Sql("UPDATE CarModels SET Name='Nissan' WHERE Id=2;");
            Sql("UPDATE CarModels SET Name='BMW' WHERE Id=3;");
            Sql("UPDATE CarModels SET Name='Chevrolet' WHERE Id=4;");
            Sql("UPDATE CarModels SET Name='Hyundai' WHERE Id=5;");
            Sql("UPDATE CarModels SET Name='Mitsubishi' WHERE Id=6;");
        }
        
        public override void Down()
        {
        }
    }
}
