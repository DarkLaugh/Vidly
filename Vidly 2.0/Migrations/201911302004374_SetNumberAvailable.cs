namespace Vidly_2._0.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SetNumberAvailable : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MovieModels SET NumberAvailable = NumberInStock");
        }
        
        public override void Down()
        {
            DropColumn("dbo.MovieModels", "NumberAvailable");
        }
    }
}
