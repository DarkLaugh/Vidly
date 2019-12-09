namespace Vidly_2._0.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAnnotationToCustomerNames : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.CustomerModels", "FirstName", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.CustomerModels", "LastName", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.CustomerModels", "LastName", c => c.String());
            AlterColumn("dbo.CustomerModels", "FirstName", c => c.String());
        }
    }
}
