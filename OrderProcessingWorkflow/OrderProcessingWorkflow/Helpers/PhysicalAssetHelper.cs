using OrderProcessingWorkflow.Models;
using OrderProcessingWorkflow.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OrderProcessingWorkflow.Helpers
{
    public partial class MethodHelper
    {
        public List<PaymentResultModel> ProcessPhysicalPayment(List<PaymentTaskMaster> paymentTaskMaster)
        {
            try
            {
                List<PaymentResultModel> paymentResultModelsList = new List<PaymentResultModel>();
                foreach (var item in paymentTaskMaster)
                {
                    PaymentResultModel paymentResultModel = new PaymentResultModel();
                    switch (item.TaskName)
                    {
                        case "AgentCommisionPayment":
                            paymentResultModel.text = "Commission payment generated to agent!!";
                            paymentResultModelsList.Add(paymentResultModel);
                            break;
                        case "ShippingPackingSlip":
                            paymentResultModel.text = "Packing Slip generated for shipping!!";
                            paymentResultModelsList.Add(paymentResultModel);
                            break;
                        default: break;
                    }
                }
                return paymentResultModelsList;
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}