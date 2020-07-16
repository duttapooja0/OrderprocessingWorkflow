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
        

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}