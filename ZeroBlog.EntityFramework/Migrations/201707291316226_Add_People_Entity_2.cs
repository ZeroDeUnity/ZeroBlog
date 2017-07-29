namespace ZeroBlog.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_People_Entity_2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.People", "kkk", c => c.String());
            AddColumn("dbo.People", "LikeFoot", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.People", "kkk");
            DropColumn("dbo.People", "LikeFoot");
        }
    }
}
