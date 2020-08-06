namespace TestTask_WF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class required_fields : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.WorkTimes", "CurrentRole", c => c.String(nullable: false));
            AlterColumn("dbo.WorkTimes", "ActivType", c => c.String(nullable: false));
            AlterColumn("dbo.WorkTimes", "CurrentProject", c => c.String(nullable: false));
            AlterColumn("dbo.WorkTimes", "TimePeriod", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.WorkTimes", "TimePeriod", c => c.String());
            AlterColumn("dbo.WorkTimes", "CurrentProject", c => c.String());
            AlterColumn("dbo.WorkTimes", "ActivType", c => c.String());
            AlterColumn("dbo.WorkTimes", "CurrentRole", c => c.String());
        }
    }
}
