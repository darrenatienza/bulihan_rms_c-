namespace BulihanRMS.Queries.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update372020 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PersonalInfoes", "IsResidence", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.PersonalInfoes", "IsResidence");
        }
    }
}
