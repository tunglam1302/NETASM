namespace MVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateCustomerField : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FullName = c.String(nullable: false, unicode: false),
                        Email = c.String(nullable: false, maxLength: 20, storeType: "nvarchar"),
                        Phone = c.String(nullable: false, unicode: false),
                        Password = c.String(nullable: false, unicode: false),
                        ConfirmPassword = c.String(nullable: false, unicode: false),
                        Age = c.String(nullable: false, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Customers");
        }
    }
}
