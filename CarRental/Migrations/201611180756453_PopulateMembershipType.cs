namespace CarRental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMembershipType : DbMigration
    {
        public override void Up()
        {
           Sql("INSERT INTO MembershipTypes (Id, DurationInMonth, SignUpFee, DiscountRate) VALUES (1, 0, 0, 0)");
           Sql("INSERT INTO MembershipTypes (Id, DurationInMonth, SignUpFee, DiscountRate) VALUES (2, 1, 30, 10)");
           Sql("INSERT INTO MembershipTypes (Id, DurationInMonth, SignUpFee, DiscountRate) VALUES (3, 3, 60, 20)");
           Sql("INSERT INTO MembershipTypes (Id, DurationInMonth, SignUpFee, DiscountRate) VALUES (4, 12, 180, 30)");
        }
        
        public override void Down()
        {
        }
    }
}
