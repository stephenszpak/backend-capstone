namespace SilkScreenOrder.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedmodelschemapart5 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.OrderForms", "Apparel_ApparelId", "dbo.Apparels");
            DropForeignKey("dbo.OrderForms", "Customer_CustomerId", "dbo.Customers");
            DropForeignKey("dbo.OrderForms", "Design_DesignId", "dbo.Designs");
            DropIndex("dbo.OrderForms", new[] { "Apparel_ApparelId" });
            DropIndex("dbo.OrderForms", new[] { "Customer_CustomerId" });
            DropIndex("dbo.OrderForms", new[] { "Design_DesignId" });
            DropColumn("dbo.Apparels", "ApparelId");
            DropColumn("dbo.Customers", "CustomerId");
            DropColumn("dbo.Designs", "DesignId");
            RenameColumn(table: "dbo.Apparels", name: "Apparel_ApparelId", newName: "ApparelId");
            RenameColumn(table: "dbo.Customers", name: "Customer_CustomerId", newName: "CustomerId");
            RenameColumn(table: "dbo.Designs", name: "Design_DesignId", newName: "DesignId");
            DropPrimaryKey("dbo.Apparels");
            DropPrimaryKey("dbo.Customers");
            DropPrimaryKey("dbo.Designs");
            AlterColumn("dbo.Apparels", "ApparelId", c => c.Int(nullable: false));
            AlterColumn("dbo.Customers", "CustomerId", c => c.Int(nullable: false));
            AlterColumn("dbo.Designs", "DesignId", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Apparels", "ApparelId");
            AddPrimaryKey("dbo.Customers", "CustomerId");
            AddPrimaryKey("dbo.Designs", "DesignId");
            CreateIndex("dbo.Apparels", "ApparelId");
            CreateIndex("dbo.Customers", "CustomerId");
            CreateIndex("dbo.Designs", "DesignId");
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
            DropColumn("dbo.OrderForms", "AdditionalNotes");
            DropColumn("dbo.OrderForms", "TotalPrice");
            DropColumn("dbo.OrderForms", "Apparel_ApparelId");
            DropColumn("dbo.OrderForms", "Customer_CustomerId");
            DropColumn("dbo.OrderForms", "Design_DesignId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.OrderForms", "Design_DesignId", c => c.Int());
            AddColumn("dbo.OrderForms", "Customer_CustomerId", c => c.Int());
            AddColumn("dbo.OrderForms", "Apparel_ApparelId", c => c.Int());
            AddColumn("dbo.OrderForms", "TotalPrice", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.OrderForms", "AdditionalNotes", c => c.String());
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
            DropIndex("dbo.Designs", new[] { "DesignId" });
            DropIndex("dbo.Customers", new[] { "CustomerId" });
            DropIndex("dbo.Apparels", new[] { "ApparelId" });
            DropPrimaryKey("dbo.Designs");
            DropPrimaryKey("dbo.Customers");
            DropPrimaryKey("dbo.Apparels");
            AlterColumn("dbo.Designs", "DesignId", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Customers", "CustomerId", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Apparels", "ApparelId", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Designs", "DesignId");
            AddPrimaryKey("dbo.Customers", "CustomerId");
            AddPrimaryKey("dbo.Apparels", "ApparelId");
            RenameColumn(table: "dbo.Designs", name: "DesignId", newName: "Design_DesignId");
            RenameColumn(table: "dbo.Customers", name: "CustomerId", newName: "Customer_CustomerId");
            RenameColumn(table: "dbo.Apparels", name: "ApparelId", newName: "Apparel_ApparelId");
            AddColumn("dbo.Designs", "DesignId", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.Customers", "CustomerId", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.Apparels", "ApparelId", c => c.Int(nullable: false, identity: true));
            CreateIndex("dbo.OrderForms", "Design_DesignId");
            CreateIndex("dbo.OrderForms", "Customer_CustomerId");
            CreateIndex("dbo.OrderForms", "Apparel_ApparelId");
            AddForeignKey("dbo.OrderForms", "Design_DesignId", "dbo.Designs", "DesignId");
            AddForeignKey("dbo.OrderForms", "Customer_CustomerId", "dbo.Customers", "CustomerId");
            AddForeignKey("dbo.OrderForms", "Apparel_ApparelId", "dbo.Apparels", "ApparelId");
        }
    }
}
