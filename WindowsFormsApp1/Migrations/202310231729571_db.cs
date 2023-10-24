namespace WindowsFormsApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class db : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Product_id = c.Int(nullable: false),
                        User_id = c.Int(nullable: false),
                        Count = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Products", t => t.Product_id, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.User_id, cascadeDelete: true)
                .Index(t => t.Product_id)
                .Index(t => t.User_id);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Price = c.Int(nullable: false),
                        Count = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        PhoneNumber = c.String(),
                        Adres = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "User_id", "dbo.Users");
            DropForeignKey("dbo.Orders", "Product_id", "dbo.Products");
            DropIndex("dbo.Orders", new[] { "User_id" });
            DropIndex("dbo.Orders", new[] { "Product_id" });
            DropTable("dbo.Users");
            DropTable("dbo.Products");
            DropTable("dbo.Orders");
        }
    }
}
