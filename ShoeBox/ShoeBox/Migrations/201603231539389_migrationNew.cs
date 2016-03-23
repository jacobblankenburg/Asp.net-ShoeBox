namespace ShoeBox.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migrationNew : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "BoxPreference", c => c.Int(nullable: false));
            AddColumn("dbo.Customers", "SubscriptionType", c => c.Int(nullable: false));
            AddColumn("dbo.Customers", "BillingAmount", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropColumn("dbo.Customers", "ShoeSize");
            DropColumn("dbo.Customers", "ShoePreference");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "ShoePreference", c => c.String());
            AddColumn("dbo.Customers", "ShoeSize", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropColumn("dbo.Customers", "BillingAmount");
            DropColumn("dbo.Customers", "SubscriptionType");
            DropColumn("dbo.Customers", "BoxPreference");
        }
    }
}
