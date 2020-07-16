using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations.Design;
using System.Linq;
using System.Web;

namespace OrderProcessingWorkflow.Models
{
    public class OPWDbContext:DbContext
    {
        public OPWDbContext():base("OrderProcessing")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<OPWDbContext, Migrations.Configuration>());
            this.Configuration.LazyLoadingEnabled = false;
            this.Configuration.ProxyCreationEnabled = false;
        }

        public DbSet<ProductMaster> ProductMasters { get; set; }
        public DbSet<PaymentTaskMaster> PaymentTaskMasters { get; set; }
    }
}