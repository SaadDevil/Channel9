namespace Channel9.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addBirhtdateAppUser1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "BirthDate", c => c.DateTime(nullable: false));
            DropColumn("dbo.AspNetUsers", "DateOfBirth");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetUsers", "DateOfBirth", c => c.DateTime(nullable: false));
            DropColumn("dbo.AspNetUsers", "BirthDate");
        }
    }
}
