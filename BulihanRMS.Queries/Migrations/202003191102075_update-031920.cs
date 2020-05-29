namespace BulihanRMS.Queries.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update031920 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BizRecords",
                c => new
                    {
                        BizRecordID = c.Int(nullable: false, identity: true),
                        BusinessName = c.String(),
                        PersonalInfoID = c.Int(nullable: false),
                        Address = c.String(),
                        ContactNumber = c.String(),
                        ImageName = c.String(),
                    })
                .PrimaryKey(t => t.BizRecordID)
                .ForeignKey("dbo.PersonalInfoes", t => t.PersonalInfoID, cascadeDelete: true)
                .Index(t => t.PersonalInfoID);
            
            CreateTable(
                "dbo.BizWorkers",
                c => new
                    {
                        BizWorkerID = c.Int(nullable: false, identity: true),
                        PersonalInfoID = c.Int(nullable: false),
                        BizRecordID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.BizWorkerID)
                .ForeignKey("dbo.BizRecords", t => t.BizRecordID, cascadeDelete: true)
                .ForeignKey("dbo.PersonalInfoes", t => t.PersonalInfoID, cascadeDelete: false)
                .Index(t => t.PersonalInfoID)
                .Index(t => t.BizRecordID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.BizRecords", "PersonalInfoID", "dbo.PersonalInfoes");
            DropForeignKey("dbo.BizWorkers", "PersonalInfoID", "dbo.PersonalInfoes");
            DropForeignKey("dbo.BizWorkers", "BizRecordID", "dbo.BizRecords");
            DropIndex("dbo.BizWorkers", new[] { "BizRecordID" });
            DropIndex("dbo.BizWorkers", new[] { "PersonalInfoID" });
            DropIndex("dbo.BizRecords", new[] { "PersonalInfoID" });
            DropTable("dbo.BizWorkers");
            DropTable("dbo.BizRecords");
        }
    }
}
