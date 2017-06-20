namespace SilkScreenOrder.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialCreate : DbMigration
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
                        AmountOfColorsOfDesign = c.String(maxLength: 5),
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
                        AdditionalNotes = c.String(),
                        PrintingFee = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TotalPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Apparel_ApparelId = c.Int(),
                        Customer_CustomerId = c.Int(),
                        Design_DesignId = c.Int(),
                    })
                .PrimaryKey(t => t.OrderFormId)
                .ForeignKey("dbo.Apparels", t => t.Apparel_ApparelId)
                .ForeignKey("dbo.Customers", t => t.Customer_CustomerId)
                .ForeignKey("dbo.Designs", t => t.Design_DesignId)
                .Index(t => t.Apparel_ApparelId)
                .Index(t => t.Customer_CustomerId)
                .Index(t => t.Design_DesignId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OrderForms", "Design_DesignId", "dbo.Designs");
            DropForeignKey("dbo.OrderForms", "Customer_CustomerId", "dbo.Customers");
            DropForeignKey("dbo.OrderForms", "Apparel_ApparelId", "dbo.Apparels");
            DropIndex("dbo.OrderForms", new[] { "Design_DesignId" });
            DropIndex("dbo.OrderForms", new[] { "Customer_CustomerId" });
            DropIndex("dbo.OrderForms", new[] { "Apparel_ApparelId" });
            DropTable("dbo.OrderForms");
            DropTable("dbo.Designs");
            DropTable("dbo.Customers");
            DropTable("dbo.Apparels");
        }
    }
}
