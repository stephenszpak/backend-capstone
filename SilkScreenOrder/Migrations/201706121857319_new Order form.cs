namespace SilkScreenOrder.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newOrderform : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.OrderForms",
                c => new
                    {
                        OrderFormId = c.Int(nullable: false, identity: true),
                        OrderDate = c.DateTime(nullable: false),
                        OrderDueDate = c.DateTime(nullable: false),
                        CustomerName = c.String(),
                        CustomerAddress = c.String(),
                        ApparelType = c.String(),
                        ApparelBrand = c.String(),
                        ApparelQuantity = c.Int(nullable: false),
                        ApparelPricePerPiece = c.Decimal(nullable: false, precision: 18, scale: 2),
                        AmountOfColorsOfDesign = c.String(),
                        DesignFee = c.Decimal(nullable: false, precision: 18, scale: 2),
                        AdditionalNotesToPrinter = c.String(),
                        TotalPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.OrderFormId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.OrderForms");
        }
    }
}
