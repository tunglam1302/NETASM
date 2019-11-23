namespace MVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddField : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Members", "createAt", c => c.Long(nullable: false));
            AddColumn("dbo.Members", "updateAt", c => c.Long(nullable: false));
            AddColumn("dbo.Members", "deleteAt", c => c.Long(nullable: false));
            AddColumn("dbo.Members", "status", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Members", "status");
            DropColumn("dbo.Members", "deleteAt");
            DropColumn("dbo.Members", "updateAt");
            DropColumn("dbo.Members", "createAt");
        }
    }
}
