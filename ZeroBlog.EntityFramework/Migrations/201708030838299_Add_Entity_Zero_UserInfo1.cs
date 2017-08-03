namespace ZeroBlog.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_Entity_Zero_UserInfo1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Zero_UserInfo", "mailbox", c => c.String(maxLength: 50));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Zero_UserInfo", "mailbox");
        }
    }
}
