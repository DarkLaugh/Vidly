namespace Vidly_2._0.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenres : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MovieModels", "ReleaseDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.MovieModels", "DateAdded", c => c.DateTime(nullable: false));
            AddColumn("dbo.MovieModels", "NumberInStock", c => c.Int(nullable: false));
            Sql("INSERT INTO GenreModels (Id, Name) VALUES (1, 'Action')");
            Sql("INSERT INTO GenreModels (Id, Name) VALUES (2, 'Thriller')");
            Sql("INSERT INTO GenreModels (Id, Name) VALUES (3, 'Family')");
            Sql("INSERT INTO GenreModels (Id, Name) VALUES (4, 'Romance')");
            Sql("INSERT INTO GenreModels (Id, Name) VALUES (5, 'Comedy')");
        }

        public override void Down()
        {
            DropColumn("dbo.MovieModels", "NumberInStock");
            DropColumn("dbo.MovieModels", "DateAdded");
            DropColumn("dbo.MovieModels", "ReleaseDate");
        }
    }
}
