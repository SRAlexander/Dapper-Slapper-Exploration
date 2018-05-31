namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.LogEntries",
                c => new
                    {
                        UniqueId = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        Message = c.String(),
                    })
                .PrimaryKey(t => t.UniqueId);
            
            CreateTable(
                "dbo.Patients",
                c => new
                    {
                        UniqueId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        Surname = c.String(),
                        NhsNumber = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UniqueId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Patients");
            DropTable("dbo.LogEntries");
        }
    }
}
