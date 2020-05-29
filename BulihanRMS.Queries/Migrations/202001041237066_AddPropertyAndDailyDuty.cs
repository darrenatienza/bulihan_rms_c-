namespace BulihanRMS.Queries.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPropertyAndDailyDuty : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DailyDuties",
                c => new
                    {
                        DailyDutyID = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        PersonalInfoID = c.Int(nullable: false),
                        In = c.DateTime(),
                        Out = c.DateTime(),
                    })
                .PrimaryKey(t => t.DailyDutyID)
                .ForeignKey("dbo.PersonalInfoes", t => t.PersonalInfoID, cascadeDelete: true)
                .Index(t => t.PersonalInfoID);
            
            CreateTable(
                "dbo.Properties",
                c => new
                    {
                        PropertyID = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        Quantiy = c.Int(nullable: false),
                        Remarks = c.String(),
                        PropertyTypeID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PropertyID)
                .ForeignKey("dbo.PropertyTypes", t => t.PropertyTypeID, cascadeDelete: true)
                .Index(t => t.PropertyTypeID);
            
            CreateTable(
                "dbo.PropertyTypes",
                c => new
                    {
                        PropertyTypeID = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.PropertyTypeID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Properties", "PropertyTypeID", "dbo.PropertyTypes");
            DropForeignKey("dbo.DailyDuties", "PersonalInfoID", "dbo.PersonalInfoes");
            DropIndex("dbo.Properties", new[] { "PropertyTypeID" });
            DropIndex("dbo.DailyDuties", new[] { "PersonalInfoID" });
            DropTable("dbo.PropertyTypes");
            DropTable("dbo.Properties");
            DropTable("dbo.DailyDuties");
        }
    }
}
