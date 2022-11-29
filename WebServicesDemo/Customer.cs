using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebServicesDemo
{
    public class Customer
    {
        public int Id { get; set; } 
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int Age { get; set; }
        public DateTime CreateDate { get; set; }
    }
}