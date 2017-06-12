namespace SilkScreenOrder.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class reworkingDatabase : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Apparels", "ApparelType", c => c.String());
            AddColumn("dbo.Apparels", "ApparelQuantity", c => c.Int(nullable: false));
            AddColumn("dbo.Apparels", "ApparelPricePerPiece", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Apparels", "ApparelColor", c => c.String());
            AddColumn("dbo.Designs", "AmountOfColorsOfDesign", c => c.String());
            AddColumn("dbo.Designs", "DesignHeight", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Designs", "DesignWidth", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Designs", "LogoLocations", c => c.String());
            AddColumn("dbo.OrderForms", "SalesPerson", c => c.String());
            AddColumn("dbo.OrderForms", "CustomerPhone", c => c.Int(nullable: false));
            AddColumn("dbo.OrderForms", "ApparelColor", c => c.String());
            AddColumn("dbo.OrderForms", "DesignHeight", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.OrderForms", "DesignWidth", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.OrderForms", "LogoLocations", c => c.String());
            AddColumn("dbo.OrderForms", "InkColorsToBeUsed", c => c.String());
            AddColumn("dbo.OrderForms", "AdditionalNotes", c => c.String());
            DropColumn("dbo.Apparels", "NumberOfItems");
            DropColumn("dbo.Designs", "NumberOfColors");
            DropColumn("dbo.Designs", "CustomerProvidedDesign");
            DropColumn("dbo.OrderForms", "AdditionalNotesToPrinter");
        }
        
        public override void Down()
        {
            AddColumn("dbo.OrderForms", "AdditionalNotesToPrinter", c => c.String());
            AddColumn("dbo.Designs", "CustomerProvidedDesign", c => c.Boolean(nullable: false));
            AddColumn("dbo.Designs", "NumberOfColors", c => c.String());
            AddColumn("dbo.Apparels", "NumberOfItems", c => c.Int(nullable: false));
            DropColumn("dbo.OrderForms", "AdditionalNotes");
            DropColumn("dbo.OrderForms", "InkColorsToBeUsed");
            DropColumn("dbo.OrderForms", "LogoLocations");
            DropColumn("dbo.OrderForms", "DesignWidth");
            DropColumn("dbo.OrderForms", "DesignHeight");
            DropColumn("dbo.OrderForms", "ApparelColor");
            DropColumn("dbo.OrderForms", "CustomerPhone");
            DropColumn("dbo.OrderForms", "SalesPerson");
            DropColumn("dbo.Designs", "LogoLocations");
            DropColumn("dbo.Designs", "DesignWidth");
            DropColumn("dbo.Designs", "DesignHeight");
            DropColumn("dbo.Designs", "AmountOfColorsOfDesign");
            DropColumn("dbo.Apparels", "ApparelColor");
            DropColumn("dbo.Apparels", "ApparelPricePerPiece");
            DropColumn("dbo.Apparels", "ApparelQuantity");
            DropColumn("dbo.Apparels", "ApparelType");
        }
    }
}
