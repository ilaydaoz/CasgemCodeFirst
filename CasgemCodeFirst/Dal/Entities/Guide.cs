﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CasgemCodeFirst.Dal.Entities
{
    public class Guide
    {
        public int GuideID { get; set; }
        public string GuideName { get; set; }
        public string GuideTitle { get; set; }
        public string GuideImageURL { get; set; }
       
    }
}