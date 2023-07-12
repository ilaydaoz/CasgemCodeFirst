using CasgemCodeFirst.Dal.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CasgemCodeFirst.Controllers
{
    public class DefaultController : Controller
    {
        TravelContext travelContext = new TravelContext();
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
            var values = travelContext.Destinations.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialFeature()
        {
            return PartialView();
        }
        
        public PartialViewResult PartialExplore()
        {
            return PartialView();
        }
        public PartialViewResult PartialNavbar()
        {
            return PartialView();
        }
    }
}