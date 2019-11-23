namespace MVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateDB : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.Customers");
            DropTable("dbo.Members");
            DropTable("dbo.Songs");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Songs",
                c => new
                    {
                        id = c.Long(nullable: false, identity: true),
                        name = c.String(unicode: false),
                        description = c.String(unicode: false),
                        singer = c.String(unicode: false),
                        author = c.String(unicode: false),
                        thumbnail = c.String(unicode: false),
                        link = c.String(unicode: false),
                        createAt = c.Long(nullable: false),
                        updateAt = c.Long(nullable: false),
                        deleteAt = c.Long(nullable: false),
                        status = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Members",
                c => new
                    {
                        id = c.Long(nullable: false, identity: true),
                        firstName = c.String(unicode: false),
                        lastName = c.String(unicode: false),
                        avatar = c.String(unicode: false),
                        phone = c.String(unicode: false),
                        address = c.String(unicode: false),
                        introduction = c.String(unicode: false),
                        gender = c.Int(nullable: false),
                        birthday = c.String(unicode: false),
                        email = c.String(unicode: false),
                        password = c.String(unicode: false),
                        createAt = c.Long(nullable: false),
                        updateAt = c.Long(nullable: false),
                        deleteAt = c.Long(nullable: false),
                        status = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FullName = c.String(nullable: false, unicode: false),
                        Email = c.String(nullable: false, maxLength: 30, storeType: "nvarchar"),
                        Phone = c.String(nullable: false, unicode: false),
                        Password = c.String(nullable: false, unicode: false),
                        ConfirmPassword = c.String(nullable: false, unicode: false),
                        Age = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
    }
}
