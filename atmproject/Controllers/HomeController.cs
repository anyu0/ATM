using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace atmproject.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
 /*       public ActionResult BankAccount()
        {
            ViewBag.Message = "Bank Account access";
            var bankaccounts = from b in BankAccountController.GetBankAccountList()
                            orderby b.ID
                            select b;
            return View(bankaccounts);
        }
        */
        public ActionResult About()
        {
            ViewBag.Message = "This is our team's Bank of 3101 ATM Machine.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact Us.";

            return View();
        }
    }
}