namespace SilkScreenOrder.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class orderThingy : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Orders", "apparel_ApparelId", "dbo.Apparels");
            DropForeignKey("dbo.Orders", "customer_CustomerId", "dbo.Customers");
            DropForeignKey("dbo.Orders", "design_DesignId", "dbo.Designs");
            DropIndex("dbo.Orders", new[] { "apparel_ApparelId" });
            DropIndex("dbo.Orders", new[] { "customer_CustomerId" });
            DropIndex("dbo.Orders", new[] { "design_DesignId" });
            AddColumn("dbo.Orders", "DesignId", c => c.Int(nullable: false));
            AddColumn("dbo.Orders", "CustomerId", c => c.Int(nullable: false));
            AddColumn("dbo.Orders", "ApparelId", c => c.Int(nullable: false));
            DropColumn("dbo.Orders", "apparel_ApparelId");
            DropColumn("dbo.Orders", "customer_CustomerId");
            DropColumn("dbo.Orders", "design_DesignId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Orders", "design_DesignId", c => c.Int());
            AddColumn("dbo.Orders", "customer_CustomerId", c => c.Int());
            AddColumn("dbo.Orders", "apparel_ApparelId", c => c.Int());
            DropColumn("dbo.Orders", "ApparelId");
            DropColumn("dbo.Orders", "CustomerId");
            DropColumn("dbo.Orders", "DesignId");
            CreateIndex("dbo.Orders", "design_DesignId");
            CreateIndex("dbo.Orders", "customer_CustomerId");
            CreateIndex("dbo.Orders", "apparel_ApparelId");
            AddForeignKey("dbo.Orders", "design_DesignId", "dbo.Designs", "DesignId");
            AddForeignKey("dbo.Orders", "customer_CustomerId", "dbo.Customers", "CustomerId");
            AddForeignKey("dbo.Orders", "apparel_ApparelId", "dbo.Apparels", "ApparelId");
        }
    }
}
