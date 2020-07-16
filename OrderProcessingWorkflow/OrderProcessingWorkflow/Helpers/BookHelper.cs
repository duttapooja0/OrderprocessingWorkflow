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
        public List<PaymentResultModel> ProcessBookPayment(List<PaymentTaskMaster> paymentTaskMaster)
        {
            try
            {
                List<PaymentResultModel> paymentResultModelsList = new List<PaymentResultModel>();
                foreach(var item in paymentTaskMaster)
                {
                    PaymentResultModel paymentResultModel = new PaymentResultModel();
                    switch (item.TaskName)
                    {
                        case "AgentCommisionPayment":
                            paymentResultModel.text = "Commission payment to the agent generated!!";
                            paymentResultModelsList.Add(paymentResultModel);
                            break;
                        case "RoyaltyDuplicatePackingSlip":
                            paymentResultModel.text = "Duplicate packing slip created for Royalty Department!!";
                            paymentResultModelsList.Add(paymentResultModel);
                            break;
                        default:break;
                    }
                }
                return paymentResultModelsList;
            }catch(Exception e)
            {
                return null;
            }
        }
    }
}