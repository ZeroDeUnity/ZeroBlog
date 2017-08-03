namespace ZeroBlog.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_Entity_Zero_UserInfo21 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Zero_UserInfo", "MailBox");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Zero_UserInfo", "MailBox", c => c.String(maxLength: 50));
        }
    }
}
