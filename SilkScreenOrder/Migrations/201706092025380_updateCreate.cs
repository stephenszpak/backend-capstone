namespace SilkScreenOrder.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateCreate : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Orders", "CustomerName");
            DropColumn("dbo.Orders", "DesignName");
            DropColumn("dbo.Orders", "NumberOfColors");
            DropColumn("dbo.Orders", "TypeOfApparel");
            DropColumn("dbo.Orders", "NumberOfApparel");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Orders", "NumberOfApparel", c => c.Int(nullable: false));
            AddColumn("dbo.Orders", "TypeOfApparel", c => c.String());
            AddColumn("dbo.Orders", "NumberOfColors", c => c.Int(nullable: false));
            AddColumn("dbo.Orders", "DesignName", c => c.String());
            AddColumn("dbo.Orders", "CustomerName", c => c.String());
        }
    }
}
