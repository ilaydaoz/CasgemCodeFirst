﻿using CasgemCodeFirst.Dal.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CasgemCodeFirst.Controllers
{
    public class SocialController : Controller
    {
        TravelContext travelContext = new TravelContext();
        public ActionResult Index()
        {
            var values =travelContext.SocialMedias.ToList();
            return View(values);
        }
        

        [HttpGet]
        public ActionResult AddSocialMedia()
        {
            List<SelectListItem> values = (from x in travelContext.Guides.ToList()
                                           select new SelectListItem
                                           {
                                               Value = x.GuideID.ToString(),
                                               Text = x.GuideName
                                           }).ToList();
            ViewBag.v = values;
            return View();
        }
    }
}
