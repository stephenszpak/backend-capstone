namespace SilkScreenOrder.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Apparels",
                c => new
                    {
                        ApparelId = c.Int(nullable: false, identity: true),
                        ApparelBrand = c.String(),
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
                    })
                .PrimaryKey(t => t.CustomerId);
            
            CreateTable(
                "dbo.Designs",
                c => new
                    {
                        DesignId = c.Int(nullable: false, identity: true),
                        NumberOfColors = c.String(),
                        DesignFee = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CustomerProvidedDesign = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.DesignId);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        OrderId = c.Int(nullable: false, identity: true),
                        OrderDate = c.DateTime(nullable: false),
                        DueDate = c.DateTime(nullable: false),
                        CustomerName = c.String(),
                        DesignName = c.String(),
                        NumberOfColors = c.Int(nullable: false),
                        TypeOfApparel = c.String(),
                        NumberOfApparel = c.Int(nullable: false),
                        apparel_ApparelId = c.Int(),
                        customer_CustomerId = c.Int(),
                        design_DesignId = c.Int(),
                    })
                .PrimaryKey(t => t.OrderId)
                .ForeignKey("dbo.Apparels", t => t.apparel_ApparelId)
                .ForeignKey("dbo.Customers", t => t.customer_CustomerId)
                .ForeignKey("dbo.Designs", t => t.design_DesignId)
                .Index(t => t.apparel_ApparelId)
                .Index(t => t.customer_CustomerId)
                .Index(t => t.design_DesignId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "design_DesignId", "dbo.Designs");
            DropForeignKey("dbo.Orders", "customer_CustomerId", "dbo.Customers");
            DropForeignKey("dbo.Orders", "apparel_ApparelId", "dbo.Apparels");
            DropIndex("dbo.Orders", new[] { "design_DesignId" });
            DropIndex("dbo.Orders", new[] { "customer_CustomerId" });
            DropIndex("dbo.Orders", new[] { "apparel_ApparelId" });
            DropTable("dbo.Orders");
            DropTable("dbo.Designs");
            DropTable("dbo.Customers");
            DropTable("dbo.Apparels");
        }
    }
}
