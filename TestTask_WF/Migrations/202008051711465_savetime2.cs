namespace TestTask_WF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class savetime2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.WorkTimes", "CurrentRole", c => c.String());
            AddColumn("dbo.WorkTimes", "ActivType", c => c.String());
            AddColumn("dbo.WorkTimes", "CurrentProject", c => c.String());
            AddColumn("dbo.WorkTimes", "TimePeriod", c => c.String());
            DropColumn("dbo.WorkTimes", "Role");
            DropColumn("dbo.WorkTimes", "ActivityType");
            DropColumn("dbo.WorkTimes", "Project");
            DropColumn("dbo.WorkTimes", "Time");
        }
        
        public override void Down()
        {
            AddColumn("dbo.WorkTimes", "Time", c => c.String());
            AddColumn("dbo.WorkTimes", "Project", c => c.String());
            AddColumn("dbo.WorkTimes", "ActivityType", c => c.String());
            AddColumn("dbo.WorkTimes", "Role", c => c.String());
            DropColumn("dbo.WorkTimes", "TimePeriod");
            DropColumn("dbo.WorkTimes", "CurrentProject");
            DropColumn("dbo.WorkTimes", "ActivType");
            DropColumn("dbo.WorkTimes", "CurrentRole");
        }
    }
}
