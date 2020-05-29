namespace BulihanRMS.Queries.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddOfficialTableAndAddContactNumberInPersonalInfo : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.OfficialGroups",
                c => new
                    {
                        OfficialGroupID = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.OfficialGroupID);
            
            CreateTable(
                "dbo.OfficialPositions",
                c => new
                    {
                        OfficialPositionID = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.OfficialPositionID);
            
            CreateTable(
                "dbo.Officials",
                c => new
                    {
                        OfficialID = c.Int(nullable: false, identity: true),
                        PersonalInfoID = c.Int(nullable: false),
                        OfficialPositionID = c.Int(nullable: false),
                        OfficialGroupID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.OfficialID)
                .ForeignKey("dbo.OfficialGroups", t => t.OfficialGroupID, cascadeDelete: true)
                .ForeignKey("dbo.OfficialPositions", t => t.OfficialPositionID, cascadeDelete: true)
                .ForeignKey("dbo.PersonalInfoes", t => t.PersonalInfoID, cascadeDelete: true)
                .Index(t => t.PersonalInfoID)
                .Index(t => t.OfficialPositionID)
                .Index(t => t.OfficialGroupID);
            
            AddColumn("dbo.PersonalInfoes", "ContactNumber", c => c.String());
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Officials", "PersonalInfoID", "dbo.PersonalInfoes");
            DropForeignKey("dbo.Officials", "OfficialPositionID", "dbo.OfficialPositions");
            DropForeignKey("dbo.Officials", "OfficialGroupID", "dbo.OfficialGroups");
            DropIndex("dbo.Officials", new[] { "OfficialGroupID" });
            DropIndex("dbo.Officials", new[] { "OfficialPositionID" });
            DropIndex("dbo.Officials", new[] { "PersonalInfoID" });
            DropColumn("dbo.PersonalInfoes", "ContactNumber");
            DropTable("dbo.Officials");
            DropTable("dbo.OfficialPositions");
            DropTable("dbo.OfficialGroups");
        }
    }
}
