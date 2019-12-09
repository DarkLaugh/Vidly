namespace Vidly_2._0.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedRequiredAnnotationToRentalModel : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.RentalModels", "Customer_Id", "dbo.CustomerModels");
            DropForeignKey("dbo.RentalModels", "Movie_Id", "dbo.MovieModels");
            DropIndex("dbo.RentalModels", new[] { "Customer_Id" });
            DropIndex("dbo.RentalModels", new[] { "Movie_Id" });
            AlterColumn("dbo.RentalModels", "Customer_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.RentalModels", "Movie_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.RentalModels", "Customer_Id");
            CreateIndex("dbo.RentalModels", "Movie_Id");
            AddForeignKey("dbo.RentalModels", "Customer_Id", "dbo.CustomerModels", "Id", cascadeDelete: true);
            AddForeignKey("dbo.RentalModels", "Movie_Id", "dbo.MovieModels", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RentalModels", "Movie_Id", "dbo.MovieModels");
            DropForeignKey("dbo.RentalModels", "Customer_Id", "dbo.CustomerModels");
            DropIndex("dbo.RentalModels", new[] { "Movie_Id" });
            DropIndex("dbo.RentalModels", new[] { "Customer_Id" });
            AlterColumn("dbo.RentalModels", "Movie_Id", c => c.Int());
            AlterColumn("dbo.RentalModels", "Customer_Id", c => c.Int());
            CreateIndex("dbo.RentalModels", "Movie_Id");
            CreateIndex("dbo.RentalModels", "Customer_Id");
            AddForeignKey("dbo.RentalModels", "Movie_Id", "dbo.MovieModels", "Id");
            AddForeignKey("dbo.RentalModels", "Customer_Id", "dbo.CustomerModels", "Id");
        }
    }
}
