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
                    case "Membership": break;
                    case "MembershipUpgrade": break;
                    case "Video": break;
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