namespace Channel9.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class viewmodel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "MembershipTypeId_ID", c => c.Int());
            CreateIndex("dbo.AspNetUsers", "MembershipTypeId_ID");
            AddForeignKey("dbo.AspNetUsers", "MembershipTypeId_ID", "dbo.MembershipTypes", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUsers", "MembershipTypeId_ID", "dbo.MembershipTypes");
            DropIndex("dbo.AspNetUsers", new[] { "MembershipTypeId_ID" });
            DropColumn("dbo.AspNetUsers", "MembershipTypeId_ID");
        }
    }
}
