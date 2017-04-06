namespace EMA.Disaster.Recovery.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        StreetAddress = c.String(),
                        StreetAddress2 = c.String(),
                        City = c.String(),
                        State = c.String(),
                        Zip = c.String(),
                        Longitude = c.Single(nullable: false),
                        Lattitude = c.Single(nullable: false),
                        CountyMunicipality_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.CountyMunicipalities", t => t.CountyMunicipality_ID)
                .Index(t => t.CountyMunicipality_ID);
            
            CreateTable(
                "dbo.CountyMunicipalities",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        County = c.String(),
                        Municipality = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Contacts",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Phone = c.String(),
                        Phone2 = c.String(),
                        Email = c.String(),
                        Address_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Addresses", t => t.Address_ID)
                .Index(t => t.Address_ID);
            
            CreateTable(
                "dbo.IndividualPhotos",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        PhotoUrl = c.String(),
                        IndividualWorksheet_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.IndividualWorksheets", t => t.IndividualWorksheet_ID)
                .Index(t => t.IndividualWorksheet_ID);
            
            CreateTable(
                "dbo.IndividualWorksheets",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Code = c.Int(nullable: false),
                        LocationNotes = c.String(),
                        PrimaryHome = c.Boolean(nullable: false),
                        Renter = c.Boolean(nullable: false),
                        Comments = c.String(),
                        FloodInsurance = c.Boolean(nullable: false),
                        BasementWater = c.Int(nullable: false),
                        FirstFloorWater = c.Int(nullable: false),
                        WaterHeight = c.Int(nullable: false),
                        AdditionalComments = c.String(),
                        AccessorName = c.String(),
                        Date = c.String(),
                        Contact_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Contacts", t => t.Contact_ID)
                .Index(t => t.Contact_ID);
            
            CreateTable(
                "dbo.IndividualSystemDamages",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        IsMaster = c.Boolean(nullable: false),
                        System = c.String(),
                        PropertyType = c.String(),
                        PercentReplacementCost = c.Int(nullable: false),
                        IndividualWorksheet_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.IndividualWorksheets", t => t.IndividualWorksheet_ID)
                .Index(t => t.IndividualWorksheet_ID);
            
            CreateTable(
                "dbo.IndividualWorksheetDamages",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        PropertyType = c.String(),
                        DamageCategory = c.String(),
                        Damaged = c.Boolean(nullable: false),
                        EstReplacementCost = c.Int(nullable: false),
                        EstStructuralDamage = c.Int(nullable: false),
                        EstDamageToContents = c.Int(nullable: false),
                        EstTotalDamage = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.IndividualWorksheets", t => t.ID)
                .Index(t => t.ID);
            
            CreateTable(
                "dbo.SBAEconInjurySurveys",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CompanyName = c.String(),
                        DisasterDate = c.DateTime(nullable: false),
                        DisasterType = c.String(),
                        MultipleLocations = c.Boolean(nullable: false),
                        FiscalYearStart = c.DateTime(nullable: false),
                        FiscalYearEnd = c.DateTime(nullable: false),
                        LastGrossSales = c.Int(nullable: false),
                        YTDGrossSales = c.Int(nullable: false),
                        GrossSalesFromDD = c.Int(nullable: false),
                        ProjectedGrossSales = c.Int(nullable: false),
                        EstInsuranceRecovery = c.Int(nullable: false),
                        EstNormalDate = c.DateTime(nullable: false),
                        AdditionalComments = c.String(),
                        PrevPeriodStart = c.DateTime(nullable: false),
                        PrevPeriodEnd = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.SBALocationTypes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.SBAPhotos",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        SBAWorksheetID = c.Int(nullable: false),
                        PhotoUrl = c.String(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.SBAWorksheets", t => t.SBAWorksheetID, cascadeDelete: true)
                .Index(t => t.SBAWorksheetID);
            
            CreateTable(
                "dbo.SBAWorksheets",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        PropertyOwner = c.String(),
                        DisasterDate = c.DateTime(nullable: false),
                        DisasterType = c.String(),
                        ApplicantType = c.String(),
                        Comments = c.String(),
                        Contact_ID = c.Int(),
                        LocationType_ID = c.Int(),
                        SBAEconInjurySurvey_ID = c.Int(),
                        SBAPropertyMarketValue_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Contacts", t => t.Contact_ID)
                .ForeignKey("dbo.SBALocationTypes", t => t.LocationType_ID)
                .ForeignKey("dbo.SBAEconInjurySurveys", t => t.SBAEconInjurySurvey_ID)
                .ForeignKey("dbo.SBAPropertyMarketValues", t => t.ID)
                .ForeignKey("dbo.SBAPropertyMarketValues", t => t.SBAPropertyMarketValue_ID)
                .Index(t => t.ID)
                .Index(t => t.Contact_ID)
                .Index(t => t.LocationType_ID)
                .Index(t => t.SBAEconInjurySurvey_ID)
                .Index(t => t.SBAPropertyMarketValue_ID);
            
            CreateTable(
                "dbo.SBAPropertyMarketValues",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        PropertySectionStructure = c.String(),
                        PropertySectionContent = c.String(),
                        PropertySectionLand = c.String(),
                        DisasterLossStructures = c.Int(nullable: false),
                        DisasterLossContent = c.Int(nullable: false),
                        DisasterLossLand = c.Int(nullable: false),
                        InsuranceAmountStructures = c.Int(nullable: false),
                        InsuranceAmountContent = c.Int(nullable: false),
                        InsuranceAmountLand = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SBAPhotos", "SBAWorksheetID", "dbo.SBAWorksheets");
            DropForeignKey("dbo.SBAWorksheets", "SBAPropertyMarketValue_ID", "dbo.SBAPropertyMarketValues");
            DropForeignKey("dbo.SBAWorksheets", "ID", "dbo.SBAPropertyMarketValues");
            DropForeignKey("dbo.SBAWorksheets", "SBAEconInjurySurvey_ID", "dbo.SBAEconInjurySurveys");
            DropForeignKey("dbo.SBAWorksheets", "LocationType_ID", "dbo.SBALocationTypes");
            DropForeignKey("dbo.SBAWorksheets", "Contact_ID", "dbo.Contacts");
            DropForeignKey("dbo.IndividualPhotos", "IndividualWorksheet_ID", "dbo.IndividualWorksheets");
            DropForeignKey("dbo.IndividualWorksheetDamages", "ID", "dbo.IndividualWorksheets");
            DropForeignKey("dbo.IndividualSystemDamages", "IndividualWorksheet_ID", "dbo.IndividualWorksheets");
            DropForeignKey("dbo.IndividualWorksheets", "Contact_ID", "dbo.Contacts");
            DropForeignKey("dbo.Contacts", "Address_ID", "dbo.Addresses");
            DropForeignKey("dbo.Addresses", "CountyMunicipality_ID", "dbo.CountyMunicipalities");
            DropIndex("dbo.SBAWorksheets", new[] { "SBAPropertyMarketValue_ID" });
            DropIndex("dbo.SBAWorksheets", new[] { "SBAEconInjurySurvey_ID" });
            DropIndex("dbo.SBAWorksheets", new[] { "LocationType_ID" });
            DropIndex("dbo.SBAWorksheets", new[] { "Contact_ID" });
            DropIndex("dbo.SBAWorksheets", new[] { "ID" });
            DropIndex("dbo.SBAPhotos", new[] { "SBAWorksheetID" });
            DropIndex("dbo.IndividualWorksheetDamages", new[] { "ID" });
            DropIndex("dbo.IndividualSystemDamages", new[] { "IndividualWorksheet_ID" });
            DropIndex("dbo.IndividualWorksheets", new[] { "Contact_ID" });
            DropIndex("dbo.IndividualPhotos", new[] { "IndividualWorksheet_ID" });
            DropIndex("dbo.Contacts", new[] { "Address_ID" });
            DropIndex("dbo.Addresses", new[] { "CountyMunicipality_ID" });
            DropTable("dbo.SBAPropertyMarketValues");
            DropTable("dbo.SBAWorksheets");
            DropTable("dbo.SBAPhotos");
            DropTable("dbo.SBALocationTypes");
            DropTable("dbo.SBAEconInjurySurveys");
            DropTable("dbo.IndividualWorksheetDamages");
            DropTable("dbo.IndividualSystemDamages");
            DropTable("dbo.IndividualWorksheets");
            DropTable("dbo.IndividualPhotos");
            DropTable("dbo.Contacts");
            DropTable("dbo.CountyMunicipalities");
            DropTable("dbo.Addresses");
        }
    }
}
