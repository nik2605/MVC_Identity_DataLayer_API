using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVC_Identity_DataLayer_Data;

namespace MVC_Identity_DataLayer.Models
{
    public class UserModel
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Name { get; set; }
    }
}