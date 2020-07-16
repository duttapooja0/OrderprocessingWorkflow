using OrderProcessingWorkflow.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OrderProcessingWorkflow.Helpers
{
    public partial class MethodHelper
    {
        public List<PaymentTaskMaster> GetPaymentTasksByProd(Guid productId)
        {
            try
            {
                using (var ctx = new OPWDbContext())
                {
                    var paymentTasks = ctx.PaymentTaskMasters.Where(m=>m.ProductId==productId).ToList();
                    return paymentTasks;
                }
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}