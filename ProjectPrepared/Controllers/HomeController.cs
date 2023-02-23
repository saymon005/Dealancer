using ProjectPrepared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace ProjectPrepared.Controllers
{
    public class HomeController : Controller
    {
        private projectDBEntities db = new projectDBEntities();
      
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Register(viewapplicant reg)
        {
            if(ModelState.IsValid)
            {
                db.viewapplicants.Add(reg);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(Registration1 reg)
        {
            if (ModelState.IsValid)
            {
                var details = db.viewapplicants.Where(userlist => userlist.appName == reg.appName && userlist.appTypes == reg.appTypes && userlist.appPassword == reg.appPassword).ToList();

                if(details.FirstOrDefault() !=null)
                {
                    Session["appID"] = details.FirstOrDefault().appID;
                    Session["appTypes"] = details.FirstOrDefault().appTypes;
                    Session["appName"] = details.FirstOrDefault().appName;
                    
                    return RedirectToAction("StartupDash", "Home");

                }
            }
            else
            {
                ModelState.AddModelError("", "Invalid Credential");
            }
            return View(reg);
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

        public ActionResult Welcome()
        {
           
            return View();
        }
        public ActionResult NewStartup()
        {

            return View();
        }
        public ActionResult NewInvestor()
        {

            return View();
        }
        public ActionResult AdminRegister()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AdminRegister(AdminRegistration reg1)
        {
            if (ModelState.IsValid)
            {
                db.AdminRegistrations.Add(reg1);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
        public ActionResult AdminLogin()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AdminLogin(AdminRegistration1 reg1)
        {
            if (ModelState.IsValid)
            {
                var details = db.AdminRegistrations.Where(userlist => userlist.AdminEmail == reg1.AdminEmail && userlist.AdminPassword == reg1.AdminPassword).ToList();
                /*var details = (from userlist in db.Registrations
                               where userlist.UserName == reg.UserName && userlist.UserType == reg.UserType && userlist.Password == reg.Password
                               select new
                               {
                                   userlist.UserId,
                                   userlist.UserName
                               }).ToList();*/
                if (details.FirstOrDefault() != null)
                {
                    Session["AdminEmail"] = details.FirstOrDefault().AdminEmail;

                    return RedirectToAction("Index", "viewapplicants");
                }
            }
            else
            {
                ModelState.AddModelError("", "Invalid Credential");
            }
            return View(reg1);
        }
        
        public ActionResult InvestorDash()
        {

            return View();
        }
        [HttpGet]
        public ActionResult CreatePost()
        {

            return View();
        }
       [HttpPost]
        public ActionResult CreatePost(posttable cp)
        {
            db.posttables.Add(cp);
            db.SaveChanges();
            return RedirectToAction("managepost");
        }
        public ActionResult managepost()
        {
            var mng = db.posttables.ToList();
            return View(mng);
        }
        public ActionResult editpost()
        {
            return View();
        }
        public ActionResult deletepost()
        {
            return View();
        }
        public ActionResult InvestorProfile()
        {

            return View();
        }
        [HttpGet]
        public ActionResult CreateApplicant()
        {

            return View();
        }
        [HttpPost]
        public ActionResult CreateApplicant(applicaition ap)
        {
            db.applicaitions.Add(ap);
            db.SaveChanges();
            return RedirectToAction("Applicant");
        }
        public ActionResult Applicant()
        {
            var apply = db.applicaitions.ToList();
            return View(apply);
        }
        [HttpGet]
        public ActionResult createTransaction()
        {

            return View();
        }
        [HttpPost]
        public ActionResult createTransaction(transact tt)
        {
            db.transacts.Add(tt);
            db.SaveChanges();
            return RedirectToAction("InvestedCompany");
        }
        public ActionResult InvestedCompany()
        {
            var fetch = db.transacts.ToList();
            return View(fetch);
        }
        public ActionResult editTransaction()
        {

            return View();
        }
        public ActionResult deleteTransaction()
        {

            return View();
        }
        public ActionResult StartupDash()
        {
            ViewBag.Posts = db.posttables.ToList();
            return View();
        }
        public ActionResult StatProfile()
        {

            return View();
        }
        
        [HttpGet]
        public ActionResult CreateFinancialStatus()
        {

            return View();
        }
        [HttpPost]
        public ActionResult CreateFinancialStatus(financialstatu fs)
        {
            db.financialstatus.Add(fs);
            db.SaveChanges();
            return RedirectToAction("FinancialStatus");
        }
        public ActionResult FinancialStatus()
        {
            var finance = db.financialstatus.ToList();
            return View(finance);
        }
        public ActionResult CurrentRecord()
        {

            return View();
        }
        public ActionResult ViewPost()
        {
            var fetch = db.posttables.ToList();
            return View(fetch);

        }
       
        public ActionResult InvestorCompany()
        {
            var fetch = db.transacts.ToList();
            return View(fetch);
        }

    }
}