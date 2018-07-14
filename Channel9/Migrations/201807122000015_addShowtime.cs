namespace Channel9.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addShowtime : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TVShows", "ShowTime", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.TVShows", "ShowTime");
        }
    }
}
