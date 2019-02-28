using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using atmproject.Models;
namespace atmproject.Controllers
{
    public class UsersController : Controller
    {
        private static int atmbalance = 10000;
        private AccountDBEntities db = new AccountDBEntities();
        

        // GET: Users/Deposit/5
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index([Bind(Include = "AccountNumber,Balance,PIN")] Users users, string account, decimal pin)
        {
            Users users2 = db.Users.Find(account);
            if (users2 == null || users2.PIN != pin)
            {
                return RedirectToAction("IndexError");
            }
            return RedirectToAction("Balance", new { id = account });
        }
        public ActionResult IndexError()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult IndexError([Bind(Include = "AccountNumber,Balance,PIN")] Users users, string account, decimal pin)
        {
            Users users2 = db.Users.Find(account);
            if (users2 == null || users2.PIN != pin)
            {
                return RedirectToAction("IndexError");
            }
            return RedirectToAction("Balance", new { id = account});
        }


        // GET: Users/Balance/5
        public ActionResult Balance(string id)
        {
            if (id == null)
            {
                return RedirectToAction("IndexError");
            }
            Users users = db.Users.Find(id);
            if (users == null)
            {
                return RedirectToAction("IndexError");
            }
            return View(users);
        }

        // GET: Users/Deposit/5
        public ActionResult Deposit(string id)
        {
            if (id == null)
            {
                return RedirectToAction("IndexError");
            }
            Users users = db.Users.Find(id);
            if (users == null)
            {
                return RedirectToAction("IndexError");
            }
            return View(users);
        }
        // POST: Users/Deposit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Deposit(Users users, int moneyinput)
        {
            
            if (ModelState.IsValid)
            {
                System.Diagnostics.Debug.WriteLine(users.PIN);
                users.Balance += moneyinput;
                atmbalance += moneyinput;
                db.Entry(users).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Balance", new { id = users.AccountNumber} );
            }
            return View(users);
        }
        // GET: Users/Withdrawal/5
        public ActionResult Withdrawal(string id)
        {
            if (id == null)
            {
                return RedirectToAction("IndexError");
            }
            Users users = db.Users.Find(id);
            if (users == null)
            {
                return RedirectToAction("IndexError");
            }
            return View(users);
        }
        // POST: Users/Withdrawal/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Withdrawal([Bind(Include = "AccountNumber,Balance,PIN")] Users users, int moneyinput)
        {
            if (ModelState.IsValid)
            {
                if (moneyinput % 20 != 0 || users.Balance < moneyinput || moneyinput > atmbalance)
                {
                    return RedirectToAction("WithdrawalError", new { id = users.AccountNumber });
                }
                users.Balance -= moneyinput;
                atmbalance -= moneyinput;
                users.PIN = users.PIN;
                db.Entry(users).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Balance", new { id = users.AccountNumber });
            }
            return View(users);
        }

        // GET: Users/Withdrawal/5
        public ActionResult WithdrawalError(string id)
        {
            if (id == null)
            {
                return RedirectToAction("IndexError");
            }
            Users users = db.Users.Find(id);
            if (users == null)
            {
                return RedirectToAction("IndexError");
            }
            return View(users);
        }
        // POST: Users/Withdrawal/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult WithdrawalError([Bind(Include = "AccountNumber,Balance,PIN")] Users users, int moneyinput)
        {
            if (ModelState.IsValid)
            {
                if (moneyinput % 20 != 0 || users.Balance < moneyinput || moneyinput > atmbalance)
                {
                    return RedirectToAction("WithdrawalError", new { id = users.AccountNumber });
                }
                users.Balance -= moneyinput;
                users.PIN = users.PIN;
                db.Entry(users).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Balance", new { id = users.AccountNumber });
            }
            return View(users);
        }



        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
