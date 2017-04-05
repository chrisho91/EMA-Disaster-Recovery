namespace EMA.Disaster.Recovery.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Address",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CountyMunicipalityID = c.Int(nullable: false),
                        StreetAddress = c.String(),
                        StreetAddress2 = c.String(),
                        City = c.String(),
                        State = c.String(),
                        Zip = c.String(),
                        Longitude = c.Single(nullable: false),
                        Lattitude = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.CountyMunicipality", t => t.CountyMunicipalityID, cascadeDelete: true)
                .Index(t => t.CountyMunicipalityID);
            
            CreateTable(
                "dbo.CountyMunicipality",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        County = c.String(),
                        Municipality = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Contact",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        AddressID = c.Int(nullable: false),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Phone = c.String(),
                        Phone2 = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Address", t => t.AddressID, cascadeDelete: true)
                .Index(t => t.AddressID);
            
            CreateTable(
                "dbo.IndividualPhotos",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        IndividualWorksheetID = c.Int(nullable: false),
                        PhotoUrl = c.String(),
                        IndividualWorksheet_IndividualWorksheetDamageID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.IndividualWorksheet", t => t.IndividualWorksheet_IndividualWorksheetDamageID)
                .Index(t => t.IndividualWorksheet_IndividualWorksheetDamageID);
            
            CreateTable(
                "dbo.IndividualWorksheet",
                c => new
                    {
                        IndividualWorksheetDamageID = c.Int(nullable: false),
                        ID = c.Int(nullable: false),
                        ContactID = c.Int(nullable: false),
                        Code = c.Int(nullable: false),
                        LocationNotes = c.String(),
                        PrimaryHome = c.Boolean(nullable: false),
                        Renter = c.Boolean(nullable: false),
                        Comments = c.String(),
                        FloodInsurance = c.Boolean(nullable: false),
                        BasementWater = c.Boolean(nullable: false),
                        FirstFloorWater = c.Boolean(nullable: false),
                        WaterHeight = c.Int(nullable: false),
                        AdditionalComments = c.String(),
                        AccessorName = c.String(),
                        Date = c.DateTime(nullable: false),
                        IndividualWorksheetDamage_ID = c.Int(),
                    })
                .PrimaryKey(t => t.IndividualWorksheetDamageID)
                .ForeignKey("dbo.Contact", t => t.ContactID, cascadeDelete: true)
                .ForeignKey("dbo.IndividualWorksheetDamage", t => t.IndividualWorksheetDamageID)
                .ForeignKey("dbo.IndividualWorksheetDamage", t => t.IndividualWorksheetDamage_ID)
                .Index(t => t.IndividualWorksheetDamageID)
                .Index(t => t.ContactID)
                .Index(t => t.IndividualWorksheetDamage_ID);
            
            CreateTable(
                "dbo.IndividualSystemDamages",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        IndividualWorksheetID = c.Int(nullable: false),
                        IsMaster = c.Boolean(nullable: false),
                        System = c.String(),
                        PropertyType = c.String(),
                        PercentReplacementCost = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.IndividualWorksheet", t => t.IndividualWorksheetID, cascadeDelete: true)
                .Index(t => t.IndividualWorksheetID);
            
            CreateTable(
                "dbo.IndividualWorksheetDamage",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        IndividualWorksheetID = c.Int(nullable: false),
                        PropertyType = c.Int(nullable: false),
                        DamageCategory = c.String(),
                        Damaged = c.Boolean(nullable: false),
                        EstReplacementCost = c.Int(nullable: false),
                        EstStructuralDamage = c.Int(nullable: false),
                        EstDamageToContents = c.Int(nullable: false),
                        EstTotalDamage = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.SBAEconInjurySurvey",
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
                "dbo.SBALocationType",
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
                        SBAWorksheet_SBAPropertyMarketValueID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.SBAWorksheet", t => t.SBAWorksheet_SBAPropertyMarketValueID)
                .Index(t => t.SBAWorksheet_SBAPropertyMarketValueID);
            
            CreateTable(
                "dbo.SBAWorksheet",
                c => new
                    {
                        SBAPropertyMarketValueID = c.Int(nullable: false),
                        ID = c.Int(nullable: false),
                        ContactID = c.Int(nullable: false),
                        SBALocationTypeID = c.Int(nullable: false),
                        SBAEconInjurySurveyID = c.Int(nullable: false),
                        PropertyOwner = c.String(),
                        DisasterDate = c.DateTime(nullable: false),
                        DisasterType = c.String(),
                        ApplicantType = c.String(),
                        Comments = c.String(),
                        SBAPropertyMarketValue_ID = c.Int(),
                    })
                .PrimaryKey(t => t.SBAPropertyMarketValueID)
                .ForeignKey("dbo.Contact", t => t.ContactID, cascadeDelete: true)
                .ForeignKey("dbo.SBALocationType", t => t.ID, cascadeDelete: true)
                .ForeignKey("dbo.SBAEconInjurySurvey", t => t.SBAEconInjurySurveyID, cascadeDelete: true)
                .ForeignKey("dbo.SBAPropertyMarketValue", t => t.SBAPropertyMarketValueID)
                .ForeignKey("dbo.SBAPropertyMarketValue", t => t.SBAPropertyMarketValue_ID)
                .Index(t => t.SBAPropertyMarketValueID)
                .Index(t => t.ID)
                .Index(t => t.ContactID)
                .Index(t => t.SBAEconInjurySurveyID)
                .Index(t => t.SBAPropertyMarketValue_ID);
            
            CreateTable(
                "dbo.SBAPropertyMarketValue",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        SBAWorksheetID = c.Int(nullable: false),
                        PropertySection = c.String(),
                        DisasterLoss = c.Int(nullable: false),
                        InsuranceAmount = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SBAPhotos", "SBAWorksheet_SBAPropertyMarketValueID", "dbo.SBAWorksheet");
            DropForeignKey("dbo.SBAWorksheet", "SBAPropertyMarketValue_ID", "dbo.SBAPropertyMarketValue");
            DropForeignKey("dbo.SBAWorksheet", "SBAPropertyMarketValueID", "dbo.SBAPropertyMarketValue");
            DropForeignKey("dbo.SBAWorksheet", "SBAEconInjurySurveyID", "dbo.SBAEconInjurySurvey");
            DropForeignKey("dbo.SBAWorksheet", "ID", "dbo.SBALocationType");
            DropForeignKey("dbo.SBAWorksheet", "ContactID", "dbo.Contact");
            DropForeignKey("dbo.IndividualPhotos", "IndividualWorksheet_IndividualWorksheetDamageID", "dbo.IndividualWorksheet");
            DropForeignKey("dbo.IndividualWorksheet", "IndividualWorksheetDamage_ID", "dbo.IndividualWorksheetDamage");
            DropForeignKey("dbo.IndividualWorksheet", "IndividualWorksheetDamageID", "dbo.IndividualWorksheetDamage");
            DropForeignKey("dbo.IndividualSystemDamages", "IndividualWorksheetID", "dbo.IndividualWorksheet");
            DropForeignKey("dbo.IndividualWorksheet", "ContactID", "dbo.Contact");
            DropForeignKey("dbo.Contact", "AddressID", "dbo.Address");
            DropForeignKey("dbo.Address", "CountyMunicipalityID", "dbo.CountyMunicipality");
            DropIndex("dbo.SBAWorksheet", new[] { "SBAPropertyMarketValue_ID" });
            DropIndex("dbo.SBAWorksheet", new[] { "SBAEconInjurySurveyID" });
            DropIndex("dbo.SBAWorksheet", new[] { "ContactID" });
            DropIndex("dbo.SBAWorksheet", new[] { "ID" });
            DropIndex("dbo.SBAWorksheet", new[] { "SBAPropertyMarketValueID" });
            DropIndex("dbo.SBAPhotos", new[] { "SBAWorksheet_SBAPropertyMarketValueID" });
            DropIndex("dbo.IndividualSystemDamages", new[] { "IndividualWorksheetID" });
            DropIndex("dbo.IndividualWorksheet", new[] { "IndividualWorksheetDamage_ID" });
            DropIndex("dbo.IndividualWorksheet", new[] { "ContactID" });
            DropIndex("dbo.IndividualWorksheet", new[] { "IndividualWorksheetDamageID" });
            DropIndex("dbo.IndividualPhotos", new[] { "IndividualWorksheet_IndividualWorksheetDamageID" });
            DropIndex("dbo.Contact", new[] { "AddressID" });
            DropIndex("dbo.Address", new[] { "CountyMunicipalityID" });
            DropTable("dbo.SBAPropertyMarketValue");
            DropTable("dbo.SBAWorksheet");
            DropTable("dbo.SBAPhotos");
            DropTable("dbo.SBALocationType");
            DropTable("dbo.SBAEconInjurySurvey");
            DropTable("dbo.IndividualWorksheetDamage");
            DropTable("dbo.IndividualSystemDamages");
            DropTable("dbo.IndividualWorksheet");
            DropTable("dbo.IndividualPhotos");
            DropTable("dbo.Contact");
            DropTable("dbo.CountyMunicipality");
            DropTable("dbo.Address");
        }
    }
}
