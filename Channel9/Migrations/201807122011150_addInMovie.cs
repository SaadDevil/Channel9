namespace Channel9.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addInMovie : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Movies", "CategoryID_ID", "dbo.Categories");
            DropForeignKey("dbo.Movies", "GenreID_ID", "dbo.Genres");
            DropForeignKey("dbo.Movies", "HeroID_ID", "dbo.Heroes");
            DropIndex("dbo.Movies", new[] { "CategoryID_ID" });
            DropIndex("dbo.Movies", new[] { "GenreID_ID" });
            DropIndex("dbo.Movies", new[] { "HeroID_ID" });
            RenameColumn(table: "dbo.Movies", name: "CategoryID_ID", newName: "CategoryID");
            RenameColumn(table: "dbo.Movies", name: "GenreID_ID", newName: "GenreID");
            RenameColumn(table: "dbo.Movies", name: "HeroID_ID", newName: "HeroID");
            AlterColumn("dbo.Movies", "CategoryID", c => c.Int(nullable: false));
            AlterColumn("dbo.Movies", "GenreID", c => c.Int(nullable: false));
            AlterColumn("dbo.Movies", "HeroID", c => c.Int(nullable: false));
            CreateIndex("dbo.Movies", "GenreID");
            CreateIndex("dbo.Movies", "CategoryID");
            CreateIndex("dbo.Movies", "HeroID");
            AddForeignKey("dbo.Movies", "CategoryID", "dbo.Categories", "ID", cascadeDelete: true);
            AddForeignKey("dbo.Movies", "GenreID", "dbo.Genres", "ID", cascadeDelete: true);
            AddForeignKey("dbo.Movies", "HeroID", "dbo.Heroes", "ID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Movies", "HeroID", "dbo.Heroes");
            DropForeignKey("dbo.Movies", "GenreID", "dbo.Genres");
            DropForeignKey("dbo.Movies", "CategoryID", "dbo.Categories");
            DropIndex("dbo.Movies", new[] { "HeroID" });
            DropIndex("dbo.Movies", new[] { "CategoryID" });
            DropIndex("dbo.Movies", new[] { "GenreID" });
            AlterColumn("dbo.Movies", "HeroID", c => c.Int());
            AlterColumn("dbo.Movies", "GenreID", c => c.Int());
            AlterColumn("dbo.Movies", "CategoryID", c => c.Int());
            RenameColumn(table: "dbo.Movies", name: "HeroID", newName: "HeroID_ID");
            RenameColumn(table: "dbo.Movies", name: "GenreID", newName: "GenreID_ID");
            RenameColumn(table: "dbo.Movies", name: "CategoryID", newName: "CategoryID_ID");
            CreateIndex("dbo.Movies", "HeroID_ID");
            CreateIndex("dbo.Movies", "GenreID_ID");
            CreateIndex("dbo.Movies", "CategoryID_ID");
            AddForeignKey("dbo.Movies", "HeroID_ID", "dbo.Heroes", "ID");
            AddForeignKey("dbo.Movies", "GenreID_ID", "dbo.Genres", "ID");
            AddForeignKey("dbo.Movies", "CategoryID_ID", "dbo.Categories", "ID");
        }
    }
}
