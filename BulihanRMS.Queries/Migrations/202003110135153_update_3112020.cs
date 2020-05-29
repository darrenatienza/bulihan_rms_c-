namespace BulihanRMS.Queries.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update_3112020 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PersonalInfoes", "IsWorker", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.PersonalInfoes", "IsWorker");
        }
    }
}
