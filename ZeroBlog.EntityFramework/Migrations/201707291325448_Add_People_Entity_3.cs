namespace ZeroBlog.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_People_Entity_3 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.People", "LikeFoot");
            DropColumn("dbo.People", "kkk");
        }
        
        public override void Down()
        {
            AddColumn("dbo.People", "kkk", c => c.String());
            AddColumn("dbo.People", "LikeFoot", c => c.String());
        }
    }
}
