namespace ZeroBlog.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_Zero_UserInfo_Entity : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Zero_UserInfo", "UpdateTime", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Zero_UserInfo", "UpdateTime");
        }
    }
}
