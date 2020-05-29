namespace BulihanRMS.Queries.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class blotter : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Blotters",
                c => new
                    {
                        BlotterID = c.Int(nullable: false, identity: true),
                        CreateTimeStamp = c.DateTime(nullable: false),
                        What = c.String(),
                        Where = c.String(),
                        When = c.String(),
                        PersonalInfoID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.BlotterID)
                .ForeignKey("dbo.PersonalInfoes", t => t.PersonalInfoID, cascadeDelete: true)
                .Index(t => t.PersonalInfoID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Blotters", "PersonalInfoID", "dbo.PersonalInfoes");
            DropIndex("dbo.Blotters", new[] { "PersonalInfoID" });
            DropTable("dbo.Blotters");
        }
    }
}
