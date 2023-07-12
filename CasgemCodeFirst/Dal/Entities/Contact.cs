using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CasgemCodeFirst.Dal.Entities
{
    public class Contact
    {
        public int ContactID { get; set; }
        public string NameSurnamae { get; set; }
        public string Mail { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public DateTime MessageDate { get; set; }
    }
}