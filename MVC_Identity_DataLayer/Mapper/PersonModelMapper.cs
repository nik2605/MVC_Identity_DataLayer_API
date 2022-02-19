using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using MVC_Identity_DataLayer.Models;
using MVC_Identity_DataLayer_Data;

namespace MVC_Identity_DataLayer.Mapper
{
    public static class PersonModelMapper
    {
        public static List<PersonModel> Map(this DataSet ds)
        {
            List<PersonModel> persons = new List<PersonModel>();
            var table = ds.Tables[0];

            foreach (DataRow row in table.Rows)
            {
                var person = new PersonModel()
                {
                    PersonID = Convert.ToInt32(row["PersonID"]),
                    PostalCode = row["PostalCode"].ToString(),
                    ProvinceName = row["ProvinceName"].ToString()
                };
                persons.Add(person);
            }

            return persons;
        }
    }
}