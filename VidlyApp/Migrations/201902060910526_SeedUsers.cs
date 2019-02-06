namespace VidlyApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'5431ba23-eac0-42a6-af52-64959384c52d', N'admin@admin.com', 0, N'AGR4I9sluWYLtOOR/m/6im1tcoS9YxiulPSbAv1GWXA5dw6SSlrQzY5jEWiJyyYy1A==', N'cd9ce78a-fc0f-439f-a201-1b1106de3903', NULL, 0, 0, NULL, 1, 0, N'admin@admin.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'7f30664b-23bf-4e62-aea2-287c7c8956e6', N'guest@guest.com', 0, N'AEpaIkzXhMH83Gxtp+t0jS95O8BoOzcvYVw4eMxt0pp7I1HHhNnLZq4NUUHDTZ+23A==', N'bb90a85c-768b-4be1-8763-23bd6472bb0b', NULL, 0, 0, NULL, 1, 0, N'guest@guest.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'9a7eaa4c-9c91-4380-8b95-a00a05d182c0', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'5431ba23-eac0-42a6-af52-64959384c52d', N'9a7eaa4c-9c91-4380-8b95-a00a05d182c0')
");
        }
        
        public override void Down()
        {
        }
    }
}
