namespace EMA.Disaster.Recovery.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SlightModelChanges : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SBAPropertyMarketValues", "PropertySectionContents", c => c.String());
            AddColumn("dbo.SBAPropertyMarketValues", "DisasterLossContents", c => c.Int(nullable: false));
            AddColumn("dbo.SBAPropertyMarketValues", "InsuranceAmountContents", c => c.Int(nullable: false));
            DropColumn("dbo.SBAPropertyMarketValues", "PropertySectionContent");
            DropColumn("dbo.SBAPropertyMarketValues", "DisasterLossContent");
            DropColumn("dbo.SBAPropertyMarketValues", "InsuranceAmountContent");
        }
        
        public override void Down()
        {
            AddColumn("dbo.SBAPropertyMarketValues", "InsuranceAmountContent", c => c.Int(nullable: false));
            AddColumn("dbo.SBAPropertyMarketValues", "DisasterLossContent", c => c.Int(nullable: false));
            AddColumn("dbo.SBAPropertyMarketValues", "PropertySectionContent", c => c.String());
            DropColumn("dbo.SBAPropertyMarketValues", "InsuranceAmountContents");
            DropColumn("dbo.SBAPropertyMarketValues", "DisasterLossContents");
            DropColumn("dbo.SBAPropertyMarketValues", "PropertySectionContents");
        }
    }
}
