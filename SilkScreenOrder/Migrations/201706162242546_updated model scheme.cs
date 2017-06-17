namespace SilkScreenOrder.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedmodelscheme : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "CustomerEmail", c => c.String());
            AddColumn("dbo.Designs", "InkColorsToBeUsed", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Designs", "InkColorsToBeUsed");
            DropColumn("dbo.Customers", "CustomerEmail");
        }
    }
}
