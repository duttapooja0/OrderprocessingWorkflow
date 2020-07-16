using OrderProcessingWorkflow.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace OrderProcessingWorkflow.Helpers
{
    public partial class MethodHelper
    {
        public List<ProductMaster> GetProductList()
        {
            try
            {
                using(var ctx=new OPWDbContext())
                {
                    var productList = ctx.ProductMasters.ToList();
                    return productList;
                }
            }catch(Exception e)
            {
                return null;
            }
        }
    }
}