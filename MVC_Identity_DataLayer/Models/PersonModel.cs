using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Identity_DataLayer.Models
{
    public class PersonModel
    {
        public int PersonID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Age { get; set; }
        public string EmailID { get; set; }
        public string Gender { get; set; }

        public string Address { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }

        public string ProvinceName { get; set; }
        public string ProvinceAbbreviation { get; set; }

    }
}