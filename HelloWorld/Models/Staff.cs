using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HelloWorld.Models
{
    public class Staff
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Lastname { get; set; }
        public string Street { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public int OrganizationId { get; set; }
        
        [ForeignKey("OrganizationId")]
        public Organization Organization { get; set; }

    }
}