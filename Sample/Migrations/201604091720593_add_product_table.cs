namespace Sample.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_product_table : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Product",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Description = c.String(nullable: false),
                        Price = c.Double(nullable: false),
                        PriceInPromotion = c.Double(nullable: false),
                        Quantity = c.Int(nullable: false),
                        Year = c.Int(nullable: false),
                        Is_InPromotion = c.Boolean(nullable: false),
                        Is_Highlighted = c.Boolean(nullable: false),
                        Is_Deleted = c.Boolean(nullable: false),
                        Deleted_At = c.String(),
                        Created_At = c.String(),
                        Modified_At = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Product");
        }
    }
}
