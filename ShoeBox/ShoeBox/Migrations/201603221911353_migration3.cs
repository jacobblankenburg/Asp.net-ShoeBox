namespace ShoeBox.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migration3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "LastName", c => c.String());
            AddColumn("dbo.Customers", "StreetAddress", c => c.String());
            AddColumn("dbo.Customers", "City", c => c.String());
            AddColumn("dbo.Customers", "Zip", c => c.Int(nullable: false));
            AddColumn("dbo.Customers", "ShoeSize", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Customers", "ShoePreference", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "ShoePreference");
            DropColumn("dbo.Customers", "ShoeSize");
            DropColumn("dbo.Customers", "Zip");
            DropColumn("dbo.Customers", "City");
            DropColumn("dbo.Customers", "StreetAddress");
            DropColumn("dbo.Customers", "LastName");
        }
    }
}
