namespace Vidly_2._0.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBirthdateToFirstCustomer : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE CustomerModels SET Birthdate = 30/12/1998 WHERE Id = 1");
        }
        
        public override void Down()
        {
        }
    }
}
