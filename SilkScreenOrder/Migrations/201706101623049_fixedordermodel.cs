namespace SilkScreenOrder.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fixedordermodel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "apparel_ApparelId", c => c.Int());
            AddColumn("dbo.Orders", "customer_CustomerId", c => c.Int());
            AddColumn("dbo.Orders", "design_DesignId", c => c.Int());
            CreateIndex("dbo.Orders", "apparel_ApparelId");
            CreateIndex("dbo.Orders", "customer_CustomerId");
            CreateIndex("dbo.Orders", "design_DesignId");
            AddForeignKey("dbo.Orders", "apparel_ApparelId", "dbo.Apparels", "ApparelId");
            AddForeignKey("dbo.Orders", "customer_CustomerId", "dbo.Customers", "CustomerId");
            AddForeignKey("dbo.Orders", "design_DesignId", "dbo.Designs", "DesignId");
            DropColumn("dbo.Orders", "DesignId");
            DropColumn("dbo.Orders", "CustomerId");
            DropColumn("dbo.Orders", "ApparelId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Orders", "ApparelId", c => c.Int(nullable: false));
            AddColumn("dbo.Orders", "CustomerId", c => c.Int(nullable: false));
            AddColumn("dbo.Orders", "DesignId", c => c.Int(nullable: false));
            DropForeignKey("dbo.Orders", "design_DesignId", "dbo.Designs");
            DropForeignKey("dbo.Orders", "customer_CustomerId", "dbo.Customers");
            DropForeignKey("dbo.Orders", "apparel_ApparelId", "dbo.Apparels");
            DropIndex("dbo.Orders", new[] { "design_DesignId" });
            DropIndex("dbo.Orders", new[] { "customer_CustomerId" });
            DropIndex("dbo.Orders", new[] { "apparel_ApparelId" });
            DropColumn("dbo.Orders", "design_DesignId");
            DropColumn("dbo.Orders", "customer_CustomerId");
            DropColumn("dbo.Orders", "apparel_ApparelId");
        }
    }
}
