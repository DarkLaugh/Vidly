namespace Vidly_2._0.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddIsSubscribedToCustomerModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CustomerModels", "IsSubscribedToNewsletter", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.CustomerModels", "IsSubscribedToNewsletter");
        }
    }
}
