namespace Channel9.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addDataAnnoation : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Customers", "MembershipTypeID_ID", "dbo.MembershipTypes");
            DropForeignKey("dbo.TVShows", "TVHostID_ID", "dbo.TVHosts");
            DropIndex("dbo.Customers", new[] { "MembershipTypeID_ID" });
            DropIndex("dbo.TVShows", new[] { "TVHostID_ID" });
            AlterColumn("dbo.TVShows", "TVHostID_ID", c => c.Int(nullable: false));
            CreateIndex("dbo.TVShows", "TVHostID_ID");
            AddForeignKey("dbo.TVShows", "TVHostID_ID", "dbo.TVHosts", "ID", cascadeDelete: true);
            DropTable("dbo.Customers");
            DropTable("dbo.MembershipTypes");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.MembershipTypes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        SignUpFee = c.Int(nullable: false),
                        Discount = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        Email = c.String(),
                        DateOfBirth = c.DateTime(nullable: false),
                        Phone = c.Long(nullable: false),
                        MembershipTypeID_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
            DropForeignKey("dbo.TVShows", "TVHostID_ID", "dbo.TVHosts");
            DropIndex("dbo.TVShows", new[] { "TVHostID_ID" });
            AlterColumn("dbo.TVShows", "TVHostID_ID", c => c.Int());
            CreateIndex("dbo.TVShows", "TVHostID_ID");
            CreateIndex("dbo.Customers", "MembershipTypeID_ID");
            AddForeignKey("dbo.TVShows", "TVHostID_ID", "dbo.TVHosts", "ID");
            AddForeignKey("dbo.Customers", "MembershipTypeID_ID", "dbo.MembershipTypes", "ID");
        }
    }
}
