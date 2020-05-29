namespace BulihanRMS.Queries.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_tables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BarangayClearances",
                c => new
                    {
                        BarangayClearanceID = c.Int(nullable: false, identity: true),
                        CreateTimeStamp = c.DateTime(nullable: false),
                        Purok = c.String(),
                        Sitio = c.String(),
                        SedulaBlg = c.String(),
                        KinuhaSa = c.String(),
                        NoongIka = c.String(),
                        ORNo = c.String(),
                        ORDate = c.String(),
                        PersonalInfoID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.BarangayClearanceID)
                .ForeignKey("dbo.PersonalInfoes", t => t.PersonalInfoID, cascadeDelete: true)
                .Index(t => t.PersonalInfoID);
            
            CreateTable(
                "dbo.BusinessClearances",
                c => new
                    {
                        BusinessClearanceID = c.Int(nullable: false, identity: true),
                        CreateTimeStamp = c.DateTime(nullable: false),
                        BusinessName = c.String(),
                        SedulaBlg = c.String(),
                        KinuhaSa = c.String(),
                        NoongIka = c.String(),
                        ORNo = c.String(),
                        ORDate = c.String(),
                        PersonalInfoID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.BusinessClearanceID)
                .ForeignKey("dbo.PersonalInfoes", t => t.PersonalInfoID, cascadeDelete: true)
                .Index(t => t.PersonalInfoID);
            
            CreateTable(
                "dbo.Indigencies",
                c => new
                    {
                        IndigencyID = c.Int(nullable: false, identity: true),
                        CreateTimeStamp = c.DateTime(nullable: false),
                        Purpose = c.String(),
                        PersonalInfoID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IndigencyID)
                .ForeignKey("dbo.PersonalInfoes", t => t.PersonalInfoID, cascadeDelete: true)
                .Index(t => t.PersonalInfoID);
            
            CreateTable(
                "dbo.Residencies",
                c => new
                    {
                        ResidencyID = c.Int(nullable: false, identity: true),
                        CreateTimeStamp = c.DateTime(nullable: false),
                        LengthOfResidency = c.String(),
                        RequestedBy = c.String(),
                        PersonalInfoID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ResidencyID)
                .ForeignKey("dbo.PersonalInfoes", t => t.PersonalInfoID, cascadeDelete: true)
                .Index(t => t.PersonalInfoID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Residencies", "PersonalInfoID", "dbo.PersonalInfoes");
            DropForeignKey("dbo.Indigencies", "PersonalInfoID", "dbo.PersonalInfoes");
            DropForeignKey("dbo.BusinessClearances", "PersonalInfoID", "dbo.PersonalInfoes");
            DropForeignKey("dbo.BarangayClearances", "PersonalInfoID", "dbo.PersonalInfoes");
            DropIndex("dbo.Residencies", new[] { "PersonalInfoID" });
            DropIndex("dbo.Indigencies", new[] { "PersonalInfoID" });
            DropIndex("dbo.BusinessClearances", new[] { "PersonalInfoID" });
            DropIndex("dbo.BarangayClearances", new[] { "PersonalInfoID" });
            DropTable("dbo.Residencies");
            DropTable("dbo.Indigencies");
            DropTable("dbo.BusinessClearances");
            DropTable("dbo.BarangayClearances");
        }
    }
}
