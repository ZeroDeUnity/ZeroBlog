namespace ZeroBlog.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateZero_UserInfoModel_1 : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Zero_UserInfo");
            AddColumn("dbo.Zero_UserInfo", "User_ID", c => c.Guid(nullable: false));
            AddPrimaryKey("dbo.Zero_UserInfo", "User_ID");
            DropColumn("dbo.Zero_UserInfo", "ID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Zero_UserInfo", "ID", c => c.Guid(nullable: false));
            DropPrimaryKey("dbo.Zero_UserInfo");
            DropColumn("dbo.Zero_UserInfo", "User_ID");
            AddPrimaryKey("dbo.Zero_UserInfo", "ID");
        }
    }
}
