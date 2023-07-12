using CasgemCodeFirst.Dal.Context;
using CasgemCodeFirst.Dal.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace CasgemCodeFirst.Controllers
{  
    
    public class LoginController : Controller
    {
        TravelContext travelContext = new TravelContext();
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Admin admin)
        {
            var values = travelContext.Admins.FirstOrDefault(x => x.UserName == admin.UserName
            && x.Pasword == admin.Pasword);
            Session["usertravel"] = values.UserName.ToString();
            return RedirectToAction("Index", "AdminGuide");
           if (values != null)
            {
                FormsAuthentication.SetAuthCookie(values.UserName, false);
                Session["usertravel"] = values.UserName.ToString();
                return RedirectToAction("Index", "AdminGuide");
            }
            else
            {
                return View();
            }
        }
    }
}