namespace SilkScreenOrder.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedprintingfee : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.OrderForms", "PrintingFee", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.OrderForms", "PrintingFee");
        }
    }
}
