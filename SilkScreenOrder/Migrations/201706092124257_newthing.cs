namespace SilkScreenOrder.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newthing : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Apparels", "NumberOfItems", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Apparels", "NumberOfItems");
        }
    }
}
