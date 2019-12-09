namespace Vidly_2._0.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBirthdateToCustomerModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CustomerModels", "Birthdate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.CustomerModels", "Birthdate");
        }
    }
}
