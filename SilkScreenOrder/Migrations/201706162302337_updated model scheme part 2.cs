namespace SilkScreenOrder.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedmodelschemepart2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.OrderForms", "Apparel_ApparelId", c => c.Int());
            AddColumn("dbo.OrderForms", "Customer_CustomerId", c => c.Int());
            AddColumn("dbo.OrderForms", "Design_DesignId", c => c.Int());
            CreateIndex("dbo.OrderForms", "Apparel_ApparelId");
            CreateIndex("dbo.OrderForms", "Customer_CustomerId");
            CreateIndex("dbo.OrderForms", "Design_DesignId");
            AddForeignKey("dbo.OrderForms", "Apparel_ApparelId", "dbo.Apparels", "ApparelId");
            AddForeignKey("dbo.OrderForms", "Customer_CustomerId", "dbo.Customers", "CustomerId");
            AddForeignKey("dbo.OrderForms", "Design_DesignId", "dbo.Designs", "DesignId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OrderForms", "Design_DesignId", "dbo.Designs");
            DropForeignKey("dbo.OrderForms", "Customer_CustomerId", "dbo.Customers");
            DropForeignKey("dbo.OrderForms", "Apparel_ApparelId", "dbo.Apparels");
            DropIndex("dbo.OrderForms", new[] { "Design_DesignId" });
            DropIndex("dbo.OrderForms", new[] { "Customer_CustomerId" });
            DropIndex("dbo.OrderForms", new[] { "Apparel_ApparelId" });
            DropColumn("dbo.OrderForms", "Design_DesignId");
            DropColumn("dbo.OrderForms", "Customer_CustomerId");
            DropColumn("dbo.OrderForms", "Apparel_ApparelId");
        }
    }
}
