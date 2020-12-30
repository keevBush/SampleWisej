using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HelloWorld.Models
{
    public class DataEvent:EventArgs
    {
        public Staff Staff { get; set; }
        public Organization Organization { get; set; }
    }
}