namespace Channel9.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addDAtaAnnotaion : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.TVShows", name: "TVHostID_ID", newName: "TVHostID");
            RenameIndex(table: "dbo.TVShows", name: "IX_TVHostID_ID", newName: "IX_TVHostID");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.TVShows", name: "IX_TVHostID", newName: "IX_TVHostID_ID");
            RenameColumn(table: "dbo.TVShows", name: "TVHostID", newName: "TVHostID_ID");
        }
    }
}
