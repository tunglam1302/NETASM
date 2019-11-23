namespace MVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateSongTable : DbMigration
    {
        public override void Up()
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
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Songs");
        }
    }
}
