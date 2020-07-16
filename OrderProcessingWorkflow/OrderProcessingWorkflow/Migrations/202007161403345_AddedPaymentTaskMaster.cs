namespace OrderProcessingWorkflow.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedPaymentTaskMaster : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PaymentTaskMasters",
                c => new
                    {
                        TaskID = c.Guid(nullable: false, identity: true,defaultValueSql:"newid()"),
                        TaskName = c.String(),
                        ProductId = c.Guid(),
                    })
                .PrimaryKey(t => t.TaskID)
                .ForeignKey("dbo.ProductMasters", t => t.ProductId)
                .Index(t => t.ProductId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PaymentTaskMasters", "ProductId", "dbo.ProductMasters");
            DropIndex("dbo.PaymentTaskMasters", new[] { "ProductId" });
            DropTable("dbo.PaymentTaskMasters");
        }
    }
}
