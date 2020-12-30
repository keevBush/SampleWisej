using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HelloWorld.Models
{
    public class Organization
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Street { get; set; }
        public int Zip { get; set; }
        public string City { get; set; }
        public string Country { get; set; }

        public ICollection<Staff> Staffs { get; set; }
    }
}