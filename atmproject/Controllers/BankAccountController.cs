using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace atmproject.Controllers
{
    public class BankAccountController : Controller
    {
        // GET: BankAccount
        public ActionResult Index()
        {
            ViewBag.Message = "Bank Account access";
            var bankaccounts = from b in GetBankAccountList()
                               orderby b.ID
                               select b;
            return View(bankaccounts);
        }

        // GET: BankAccount/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: BankAccount/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BankAccount/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: BankAccount/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: BankAccount/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: BankAccount/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BankAccount/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        [NonAction]
        public List<Models.BankAccount> GetBankAccountList()
        {
            return new List<Models.BankAccount>{
                new Models.BankAccount{
                    ID = 1,
                    Name = "Allan",
                    DateCreated = DateTime.Parse(DateTime.Today.ToString()),
                    Pin = 23
                },

                new Models.BankAccount{
                    ID = 2,
                    Name = "Carson",
                    DateCreated = DateTime.Parse(DateTime.Today.ToString()),
                    Pin = 45
                },

                new Models.BankAccount{
                    ID = 3,
                    Name = "Carson",
                    DateCreated = DateTime.Parse(DateTime.Today.ToString()),
                    Pin = 37
                },

                new Models.BankAccount{
                    ID = 4,
                    Name = "Laura",
                    DateCreated = DateTime.Parse(DateTime.Today.ToString()),
                    Pin = 26
                },
            };

        }
    }
}
