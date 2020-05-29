namespace BulihanRMS.Queries.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Children",
                c => new
                    {
                        ChildrenID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Age = c.String(),
                        Occupation = c.String(),
                        PersonalInfoID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ChildrenID)
                .ForeignKey("dbo.PersonalInfoes", t => t.PersonalInfoID, cascadeDelete: true)
                .Index(t => t.PersonalInfoID);
            
            CreateTable(
                "dbo.PersonalInfoes",
                c => new
                    {
                        PersonalInfoID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Birthday = c.DateTime(nullable: false),
                        Sex = c.String(),
                        Address = c.String(),
                        LengthOfResidency = c.String(),
                        Citizenship = c.String(),
                        CivilStatus = c.String(),
                        Religion = c.String(),
                        FathersName = c.String(),
                        FatherOccupation = c.String(),
                        MothersName = c.String(),
                        MotherOccupation = c.String(),
                        SisterCount = c.Int(nullable: false),
                        BrotherCount = c.Int(nullable: false),
                        SpouseName = c.String(),
                        SpouseOccupation = c.String(),
                        PrimarySchoolName = c.String(),
                        PrimaryInclusiveDate = c.String(),
                        PrimaryCourse = c.String(),
                        SecondarySchoolName = c.String(),
                        SecondaryInclusiveDate = c.String(),
                        SecondaryCourse = c.String(),
                        TertiarySchoolName = c.String(),
                        TertiaryInclusiveDate = c.String(),
                        TertiaryCourse = c.String(),
                        VocationalSchoolName = c.String(),
                        VocationalInclusiveDate = c.String(),
                        VocationalCourse = c.String(),
                        HasRelativesMedicalIllness = c.Boolean(nullable: false),
                        PresentOccupation = c.String(),
                        Position = c.String(),
                        EstimatedSalary = c.String(),
                        WorkingLength = c.String(),
                    })
                .PrimaryKey(t => t.PersonalInfoID);
            
            CreateTable(
                "dbo.FamilyMedicalHistories",
                c => new
                    {
                        FamilyMedicalHistoryID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Illness = c.String(),
                        PersonalInfoID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.FamilyMedicalHistoryID)
                .ForeignKey("dbo.PersonalInfoes", t => t.PersonalInfoID, cascadeDelete: true)
                .Index(t => t.PersonalInfoID);
            
            CreateTable(
                "dbo.PastJobs",
                c => new
                    {
                        PastJobID = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        InclusiveDate = c.String(),
                        Salary = c.String(),
                        ReasonOfLeaving = c.String(),
                        PersonalInfoID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PastJobID)
                .ForeignKey("dbo.PersonalInfoes", t => t.PersonalInfoID, cascadeDelete: true)
                .Index(t => t.PersonalInfoID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PastJobs", "PersonalInfoID", "dbo.PersonalInfoes");
            DropForeignKey("dbo.FamilyMedicalHistories", "PersonalInfoID", "dbo.PersonalInfoes");
            DropForeignKey("dbo.Children", "PersonalInfoID", "dbo.PersonalInfoes");
            DropIndex("dbo.PastJobs", new[] { "PersonalInfoID" });
            DropIndex("dbo.FamilyMedicalHistories", new[] { "PersonalInfoID" });
            DropIndex("dbo.Children", new[] { "PersonalInfoID" });
            DropTable("dbo.PastJobs");
            DropTable("dbo.FamilyMedicalHistories");
            DropTable("dbo.PersonalInfoes");
            DropTable("dbo.Children");
        }
    }
}
