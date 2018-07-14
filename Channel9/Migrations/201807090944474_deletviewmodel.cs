namespace Channel9.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deletviewmodel : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.AspNetUsers", "MembershipTypeId_ID", "dbo.MembershipTypes");
            DropIndex("dbo.AspNetUsers", new[] { "MembershipTypeId_ID" });
            DropColumn("dbo.AspNetUsers", "MembershipTypeId_ID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetUsers", "MembershipTypeId_ID", c => c.Int());
            CreateIndex("dbo.AspNetUsers", "MembershipTypeId_ID");
            AddForeignKey("dbo.AspNetUsers", "MembershipTypeId_ID", "dbo.MembershipTypes", "ID");
        }
    }
}
