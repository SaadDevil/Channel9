namespace Channel9.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPhoneMembershipProtery : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.AspNetUsers", "MembershipTypeId_ID", "dbo.MembershipTypes");
            DropIndex("dbo.AspNetUsers", new[] { "MembershipTypeId_ID" });
            AddColumn("dbo.AspNetUsers", "MembershipType", c => c.String());
            AddColumn("dbo.AspNetUsers", "Phone", c => c.String());
            DropColumn("dbo.AspNetUsers", "MembershipTypeId_ID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetUsers", "MembershipTypeId_ID", c => c.Int());
            DropColumn("dbo.AspNetUsers", "Phone");
            DropColumn("dbo.AspNetUsers", "MembershipType");
            CreateIndex("dbo.AspNetUsers", "MembershipTypeId_ID");
            AddForeignKey("dbo.AspNetUsers", "MembershipTypeId_ID", "dbo.MembershipTypes", "ID");
        }
    }
}
