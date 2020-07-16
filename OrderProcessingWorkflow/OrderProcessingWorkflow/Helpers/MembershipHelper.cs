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
        public List<PaymentResultModel> ProcessMembershipActivation(List<PaymentTaskMaster> paymentTaskMaster)
        {
            try
            {
                List<PaymentResultModel> paymentResultModelsList = new List<PaymentResultModel>();
                foreach (var item in paymentTaskMaster)
                {
                    PaymentResultModel paymentResultModel = new PaymentResultModel();
                    switch (item.TaskName)
                    {
                        case "ActivateMembership":
                            paymentResultModel.text = "Membership activated!!";
                            paymentResultModelsList.Add(paymentResultModel);
                            break;
                        case "SendEmail":
                            paymentResultModel.text = "Activation complete Email Sent to payer!!";
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