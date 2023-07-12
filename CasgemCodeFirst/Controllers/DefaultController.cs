using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CasgemCodeFirst.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }
        
       public PartialViewResult PartialHead()
        {
            return PartialView();
        }
        public PartialViewResult PartialContact()
        {
            return PartialView();
        }
       
        public PartialViewResult PartialDestinations()
        {
            return PartialView();
        }
        public PartialViewResult PartialFeature()
        {
            return PartialView();
        }
    }
}