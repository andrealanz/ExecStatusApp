namespace ExecStatusApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ExecStats",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        SourceMachine = c.String(nullable: false),
                        AppName = c.String(),
                        Task = c.String(),
                        Status = c.Int(nullable: false),
                        prop1 = c.Int(nullable: false),
                        prop2 = c.Int(nullable: false),
                        prop3 = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ExecStats");
        }
    }
}
