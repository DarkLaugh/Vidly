namespace Vidly_2._0.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMovieDBSetAddGenreModelandGenrePropToMovieModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MovieModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        GenreId = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.GenreModels", t => t.GenreId, cascadeDelete: true)
                .Index(t => t.GenreId);
            
            CreateTable(
                "dbo.GenreModels",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MovieModels", "GenreId", "dbo.GenreModels");
            DropIndex("dbo.MovieModels", new[] { "GenreId" });
            DropTable("dbo.GenreModels");
            DropTable("dbo.MovieModels");
        }
    }
}
