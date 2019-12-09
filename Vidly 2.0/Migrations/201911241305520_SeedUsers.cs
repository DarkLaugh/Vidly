namespace Vidly_2._0.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'09f0b86d-a0d3-4059-a49d-677de7d8d1d7', N'admin@vidly.com', 0, N'AClgcFv7CWK+/G4Oj6Hf9fqOumPKB9ef6XzvMRBvXx7GZXDYRugQjobp+5nVqrSkBw==', N'427c7d06-6178-4e9e-ab70-ea4f82b6539b', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'd89b3e2c-95e0-40fd-b0ae-9b9ac3a81bec', N'guest@vidly.com', 0, N'ABvvA85ZG3pRkn5afoK3ftHSQYTBXCF0F1dqw5GrhnJ0x4a+tMpP6DY2q+VWQAVeiA==', N'7318d594-7b05-406b-8884-81f3c592cb26', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'f352a932-96f6-4dc4-8574-1c584949e464', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'09f0b86d-a0d3-4059-a49d-677de7d8d1d7', N'f352a932-96f6-4dc4-8574-1c584949e464')
");
        }
        
        public override void Down()
        {
        }
    }
}
