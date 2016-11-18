namespace CarRental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMembershipType2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.MembershipTypes", "DurationInMonth", c => c.Byte(nullable: false));
            AlterColumn("dbo.MembershipTypes", "SignUpFee", c => c.Short(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.MembershipTypes", "SignUpFee", c => c.Byte(nullable: false));
            AlterColumn("dbo.MembershipTypes", "DurationInMonth", c => c.Short(nullable: false));
        }
    }
}
