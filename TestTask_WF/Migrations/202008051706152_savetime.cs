namespace TestTask_WF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class savetime : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.WorkTimes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Role = c.String(),
                        ActivityType = c.String(),
                        Project = c.String(),
                        Time = c.String(),
                        Date = c.DateTime(nullable: false),
                        EmployeeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.WorkTimes");
        }
    }
}
