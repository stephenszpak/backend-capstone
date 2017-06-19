namespace SilkScreenOrder.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedmaxlengthtonumberofcolors : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Designs", "AmountOfColorsOfDesign", c => c.String(maxLength: 5));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Designs", "AmountOfColorsOfDesign", c => c.String());
        }
    }
}
