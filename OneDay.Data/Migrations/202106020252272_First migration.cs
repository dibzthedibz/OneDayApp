namespace OneDay.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Firstmigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Reply",
                c => new
                    {
                        ReplyId = c.Int(nullable: false, identity: true),
                        Text = c.String(nullable: false),
                        AuthorId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.ReplyId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Reply");
        }
    }
}
