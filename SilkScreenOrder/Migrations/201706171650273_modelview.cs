namespace SilkScreenOrder.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class modelview : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.OrderForms", name: "ApparelId_ApparelId", newName: "Apparel_ApparelId");
            RenameColumn(table: "dbo.OrderForms", name: "CustomerId_CustomerId", newName: "Customer_CustomerId");
            RenameColumn(table: "dbo.OrderForms", name: "DesignId_DesignId", newName: "Design_DesignId");
            RenameIndex(table: "dbo.OrderForms", name: "IX_ApparelId_ApparelId", newName: "IX_Apparel_ApparelId");
            RenameIndex(table: "dbo.OrderForms", name: "IX_CustomerId_CustomerId", newName: "IX_Customer_CustomerId");
            RenameIndex(table: "dbo.OrderForms", name: "IX_DesignId_DesignId", newName: "IX_Design_DesignId");
            DropColumn("dbo.OrderForms", "CustomerName");
            DropColumn("dbo.OrderForms", "CustomerAddress");
            DropColumn("dbo.OrderForms", "CustomerPhone");
            DropColumn("dbo.OrderForms", "CustomerEmail");
            DropColumn("dbo.OrderForms", "ApparelType");
            DropColumn("dbo.OrderForms", "ApparelBrand");
            DropColumn("dbo.OrderForms", "ApparelQuantity");
            DropColumn("dbo.OrderForms", "ApparelPricePerPiece");
            DropColumn("dbo.OrderForms", "ApparelColor");
            DropColumn("dbo.OrderForms", "AmountOfColorsOfDesign");
            DropColumn("dbo.OrderForms", "DesignHeight");
            DropColumn("dbo.OrderForms", "DesignWidth");
            DropColumn("dbo.OrderForms", "DesignFee");
            DropColumn("dbo.OrderForms", "LogoLocations");
            DropColumn("dbo.OrderForms", "InkColorsToBeUsed");
        }
        
        public override void Down()
        {
            AddColumn("dbo.OrderForms", "InkColorsToBeUsed", c => c.String());
            AddColumn("dbo.OrderForms", "LogoLocations", c => c.String());
            AddColumn("dbo.OrderForms", "DesignFee", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.OrderForms", "DesignWidth", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.OrderForms", "DesignHeight", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.OrderForms", "AmountOfColorsOfDesign", c => c.String());
            AddColumn("dbo.OrderForms", "ApparelColor", c => c.String());
            AddColumn("dbo.OrderForms", "ApparelPricePerPiece", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.OrderForms", "ApparelQuantity", c => c.Int(nullable: false));
            AddColumn("dbo.OrderForms", "ApparelBrand", c => c.String());
            AddColumn("dbo.OrderForms", "ApparelType", c => c.String());
            AddColumn("dbo.OrderForms", "CustomerEmail", c => c.String());
            AddColumn("dbo.OrderForms", "CustomerPhone", c => c.Int(nullable: false));
            AddColumn("dbo.OrderForms", "CustomerAddress", c => c.String());
            AddColumn("dbo.OrderForms", "CustomerName", c => c.String());
            RenameIndex(table: "dbo.OrderForms", name: "IX_Design_DesignId", newName: "IX_DesignId_DesignId");
            RenameIndex(table: "dbo.OrderForms", name: "IX_Customer_CustomerId", newName: "IX_CustomerId_CustomerId");
            RenameIndex(table: "dbo.OrderForms", name: "IX_Apparel_ApparelId", newName: "IX_ApparelId_ApparelId");
            RenameColumn(table: "dbo.OrderForms", name: "Design_DesignId", newName: "DesignId_DesignId");
            RenameColumn(table: "dbo.OrderForms", name: "Customer_CustomerId", newName: "CustomerId_CustomerId");
            RenameColumn(table: "dbo.OrderForms", name: "Apparel_ApparelId", newName: "ApparelId_ApparelId");
        }
    }
}
