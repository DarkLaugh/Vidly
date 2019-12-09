namespace Vidly_2._0.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateNumberInStockVariable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.MovieModels", "NumberInStock", c => c.Byte(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.MovieModels", "NumberInStock", c => c.Int(nullable: false));
        }
    }
}
