namespace Vidly_2._0.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedDataAnnotationsToMovieModel : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.MovieModels", "Name", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.MovieModels", "Name", c => c.String());
        }
    }
}
