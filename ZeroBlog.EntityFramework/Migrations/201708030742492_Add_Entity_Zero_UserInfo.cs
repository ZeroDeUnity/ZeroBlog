namespace ZeroBlog.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_Entity_Zero_UserInfo : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Zero_UserInfo",
                c => new
                    {
                        User_ID = c.Guid(nullable: false),
                        User_Name = c.String(nullable: false, maxLength: 50),
                        User_Sex = c.Boolean(nullable: false),
                        User_Pwd = c.String(nullable: false, maxLength: 50),
                        CreateTime = c.DateTime(nullable: false),
                        LoginTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.User_ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Zero_UserInfo");
        }
    }
}
