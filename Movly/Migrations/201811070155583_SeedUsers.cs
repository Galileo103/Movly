namespace Movly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'2ff77e8f-f1a8-433e-9423-6f838c9a353e', N'admin@movly.com', 0, N'ADgn445kLhn1HYSCPL21vlukFdIh4p6yRc0DxNLn5DXVU4KvLfG4MMarIdthQI/SRw==', N'6a511d0a-c1f3-4603-81e5-47a8b0f5ee39', NULL, 0, 0, NULL, 1, 0, N'admin@movly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'58496679-2f9d-4d38-8062-64538685272c', N'gusset@movly.com', 0, N'AHqZXHb2LrCOEr+g4n2BeDJH5CcGmx3CfW6zk41lRLCMtsJdB+vDD0qE5pFMVYZhzQ==', N'2a9f1f7a-29b7-4b65-89e6-402302208959', NULL, 0, 0, NULL, 1, 0, N'gusset@movly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'18362940-fb3d-4357-9aee-7bf9b1744105', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'2ff77e8f-f1a8-433e-9423-6f838c9a353e', N'18362940-fb3d-4357-9aee-7bf9b1744105')


");
        }
        
        public override void Down()
        {
        }
    }
}
