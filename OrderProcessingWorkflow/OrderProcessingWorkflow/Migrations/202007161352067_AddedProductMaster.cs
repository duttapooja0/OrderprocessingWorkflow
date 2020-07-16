namespace OrderProcessingWorkflow.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedProductMaster : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ProductMasters",
                c => new
                    {
                        ProductID = c.Guid(nullable: false, identity: true,defaultValueSql:"newid()"),
                        ProductName = c.String(),
                    })
                .PrimaryKey(t => t.ProductID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ProductMasters");
        }
    }
}
