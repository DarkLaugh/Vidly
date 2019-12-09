namespace Vidly_2._0.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MakingCustomerBirthdateNullable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.CustomerModels", "Birthdate", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.CustomerModels", "Birthdate", c => c.DateTime(nullable: false));
        }
    }
}
