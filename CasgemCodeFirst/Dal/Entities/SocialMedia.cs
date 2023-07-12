using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CasgemCodeFirst.Dal.Entities
{
    public class SocialMedia
    {
        public int SocialMediaID { get; set; }
        public string SocialMediaName { get; set; }
        public string SocialMediaURL { get; set; }
        public int GuideID { get; set; }
        public virtual Guide Guide { get; set; }
    }
}