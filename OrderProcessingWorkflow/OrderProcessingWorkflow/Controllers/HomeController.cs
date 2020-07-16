using OrderProcessingWorkflow.Helpers;
using OrderProcessingWorkflow.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OrderProcessingWorkflow.Controllers
{
    public class HomeController : Controller
    {
        OPWDbContext dbContext;
        MethodHelper methodHelper;
        public HomeController()
        {
            dbContext = new OPWDbContext();
            methodHelper = new MethodHelper();
        }
        public ActionResult Index()
        {
            ViewBag.ProductList = methodHelper.GetProductList();
            return View();
        }
        

        public ActionResult ProcessPayment(Guid productType,string productName)
        {
            if (productType != Guid.Empty && !String.IsNullOrEmpty(productName))
            {
                var paymenttaskList = methodHelper.GetPaymentTasksByProd(productType);
                switch (productName)
                {
                    case "Book":
                        var paymentResult = methodHelper.ProcessBookPayment(paymenttaskList);
                        return Json(paymentResult, JsonRequestBehavior.AllowGet);
                    case "Membership":
                        paymentResult = methodHelper.ProcessMembershipActivation(paymenttaskList);
                        return Json(paymentResult, JsonRequestBehavior.AllowGet);
                    case "MembershipUpgrade":
                        paymentResult = methodHelper.ProcessMembershipUpgrade(paymenttaskList);
                        return Json(paymentResult, JsonRequestBehavior.AllowGet);
                    case "Video":
                        paymentResult = methodHelper.ProcessVideoPayment(paymenttaskList);
                        return Json(paymentResult, JsonRequestBehavior.AllowGet);
                    case "Physical": break;
                }

            }
            

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}