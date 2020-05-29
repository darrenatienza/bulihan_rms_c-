namespace BulihanRMS.Queries.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddColumnCreateTimeStampOnPersonalInfo : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PersonalInfoes", "CreateTimeStamp", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.PersonalInfoes", "CreateTimeStamp");
        }
    }
}
