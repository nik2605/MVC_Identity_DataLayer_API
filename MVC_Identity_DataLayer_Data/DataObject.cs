using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace MVC_Identity_DataLayer_Data
{
    public class DataObject
    {
        private string _ConnectionString;
        public DataObject()
        {
            _ConnectionString = ConfigurationManager.ConnectionStrings["MVC"].ConnectionString;
        }

        public string ConnectionString => _ConnectionString;
    }
}