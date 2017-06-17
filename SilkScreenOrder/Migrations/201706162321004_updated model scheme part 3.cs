namespace SilkScreenOrder.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedmodelschemepart3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.OrderForms", "CustomerEmail", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.OrderForms", "CustomerEmail");
        }
    }
}
