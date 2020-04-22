using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace datatablesTests.Models
{
    public class dataModel
    {
        public int id { get; set; }
        public string guid { get; set; }
        public decimal decimalData { get; set; }
        public DateTime? dateTimeData { get; set; }
        public bool boleanData { get; set; }
        public enumData enumData { get; set; }
    }
}