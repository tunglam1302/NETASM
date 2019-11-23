namespace MVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Change : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "Email", c => c.String(nullable: false, maxLength: 30, storeType: "nvarchar"));
            AlterColumn("dbo.Customers", "Age", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "Age", c => c.String(nullable: false, unicode: false));
            AlterColumn("dbo.Customers", "Email", c => c.String(nullable: false, maxLength: 20, storeType: "nvarchar"));
        }
    }
}
