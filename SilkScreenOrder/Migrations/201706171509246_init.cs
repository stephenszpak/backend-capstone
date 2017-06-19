namespace SilkScreenOrder.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Apparels",
                c => new
                    {
                        ApparelId = c.Int(nullable: false, identity: true),
                        ApparelType = c.String(),
                        ApparelBrand = c.String(),
                        ApparelQuantity = c.Int(nullable: false),
                        ApparelPricePerPiece = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ApparelColor = c.String(),
                    })
                .PrimaryKey(t => t.ApparelId);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CustomerId = c.Int(nullable: false, identity: true),
                        CustomerName = c.String(),
                        CustomerAddress = c.String(),
                        CustomerPhone = c.String(),
                        CustomerEmail = c.String(),
                    })
                .PrimaryKey(t => t.CustomerId);
            
            CreateTable(
                "dbo.Designs",
                c => new
                    {
                        DesignId = c.Int(nullable: false, identity: true),
                        AmountOfColorsOfDesign = c.String(),
                        DesignHeight = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DesignWidth = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DesignFee = c.Decimal(nullable: false, precision: 18, scale: 2),
                        LogoLocations = c.String(),
                        InkColorsToBeUsed = c.String(),
                    })
                .PrimaryKey(t => t.DesignId);
            
            CreateTable(
                "dbo.OrderForms",
                c => new
                    {
                        OrderFormId = c.Int(nullable: false, identity: true),
                        OrderDate = c.DateTime(nullable: false),
                        OrderDueDate = c.DateTime(nullable: false),
                        OrderNumber = c.Int(nullable: false),
                        SalesPerson = c.String(),
                        CustomerName = c.String(),
                        CustomerAddress = c.String(),
                        CustomerPhone = c.Int(nullable: false),
                        CustomerEmail = c.String(),
                        ApparelType = c.String(),
                        ApparelBrand = c.String(),
                        ApparelQuantity = c.Int(nullable: false),
                        ApparelPricePerPiece = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ApparelColor = c.String(),
                        AmountOfColorsOfDesign = c.String(),
                        DesignHeight = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DesignWidth = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DesignFee = c.Decimal(nullable: false, precision: 18, scale: 2),
                        LogoLocations = c.String(),
                        InkColorsToBeUsed = c.String(),
                        AdditionalNotes = c.String(),
                        TotalPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ApparelId_ApparelId = c.Int(),
                        CustomerId_CustomerId = c.Int(),
                        DesignId_DesignId = c.Int(),
                    })
                .PrimaryKey(t => t.OrderFormId)
                .ForeignKey("dbo.Apparels", t => t.ApparelId_ApparelId)
                .ForeignKey("dbo.Customers", t => t.CustomerId_CustomerId)
                .ForeignKey("dbo.Designs", t => t.DesignId_DesignId)
                .Index(t => t.ApparelId_ApparelId)
                .Index(t => t.CustomerId_CustomerId)
                .Index(t => t.DesignId_DesignId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OrderForms", "DesignId_DesignId", "dbo.Designs");
            DropForeignKey("dbo.OrderForms", "CustomerId_CustomerId", "dbo.Customers");
            DropForeignKey("dbo.OrderForms", "ApparelId_ApparelId", "dbo.Apparels");
            DropIndex("dbo.OrderForms", new[] { "DesignId_DesignId" });
            DropIndex("dbo.OrderForms", new[] { "CustomerId_CustomerId" });
            DropIndex("dbo.OrderForms", new[] { "ApparelId_ApparelId" });
            DropTable("dbo.OrderForms");
            DropTable("dbo.Designs");
            DropTable("dbo.Customers");
            DropTable("dbo.Apparels");
        }
    }
}
