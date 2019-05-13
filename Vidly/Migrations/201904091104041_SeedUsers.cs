namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'1a476114-6fee-4cdd-8d89-cffcdc43031d', N'guest@vidly.com', 0, N'ACSTIfql49+q/apdlx+SjWc6zPz+Urj4/mIsYQ7h+sBGNV2mlqdcfK9V37Us5CUnHQ==', N'67717064-4620-4294-bc70-0a60418cb848', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'cba9eec3-1bab-4bf7-a244-8e565ed6ffb3', N'admin@vidly.com', 0, N'AN6pDsiWi5t2uKECGgzD7nxbeEZ+YB49vEdU04SbZV8vKPp863ZkWjb4nCar2YZF9A==', N'46409f38-1c8a-4edc-8799-15faed1901ac', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'3dabb7ef-1329-4c26-9e21-55b028618144', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'cba9eec3-1bab-4bf7-a244-8e565ed6ffb3', N'3dabb7ef-1329-4c26-9e21-55b028618144')

");
        }
        
        public override void Down()
        {
        }
    }
}
