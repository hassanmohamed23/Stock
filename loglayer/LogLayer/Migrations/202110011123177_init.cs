namespace LogLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Catgs",
                c => new
                    {
                        Catg_ID = c.Int(nullable: false, identity: true),
                        Catg_Name = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.Catg_ID);
            
            CreateTable(
                "dbo.Items",
                c => new
                    {
                        Item_ID = c.Int(nullable: false, identity: true),
                        Item_Name = c.String(nullable: false, maxLength: 100),
                        Item_Image = c.String(),
                        Item_Catg_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Item_ID)
                .ForeignKey("dbo.Catgs", t => t.Item_Catg_ID, cascadeDelete: true)
                .Index(t => t.Item_Catg_ID);
            
            CreateTable(
                "dbo.StockContainsItems",
                c => new
                    {
                        Stock_ID = c.Int(nullable: false),
                        Item_ID = c.Int(nullable: false),
                        Item_Amount = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Stock_ID, t.Item_ID })
                .ForeignKey("dbo.Items", t => t.Item_ID, cascadeDelete: true)
                .ForeignKey("dbo.Stocks", t => t.Stock_ID, cascadeDelete: true)
                .Index(t => t.Stock_ID)
                .Index(t => t.Item_ID);
            
            CreateTable(
                "dbo.Stocks",
                c => new
                    {
                        Stock_ID = c.Int(nullable: false, identity: true),
                        Stock_Name = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.Stock_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Items", "Item_Catg_ID", "dbo.Catgs");
            DropForeignKey("dbo.StockContainsItems", "Stock_ID", "dbo.Stocks");
            DropForeignKey("dbo.StockContainsItems", "Item_ID", "dbo.Items");
            DropIndex("dbo.StockContainsItems", new[] { "Item_ID" });
            DropIndex("dbo.StockContainsItems", new[] { "Stock_ID" });
            DropIndex("dbo.Items", new[] { "Item_Catg_ID" });
            DropTable("dbo.Stocks");
            DropTable("dbo.StockContainsItems");
            DropTable("dbo.Items");
            DropTable("dbo.Catgs");
        }
    }
}
