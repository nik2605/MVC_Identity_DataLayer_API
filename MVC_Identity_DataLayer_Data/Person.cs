using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;

namespace MVC_Identity_DataLayer_Data
{
    public class Person : DataObject
    {
        public DataSet GetPersons()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("SELECT  * from PersonSummary");

            //sb.AppendLine(" p.PersonID ");
            //sb.AppendLine("    , p.FirstName ");
            //sb.AppendLine("    , p.LastName ");
            //sb.AppendLine("    , p.Age ");
            //sb.AppendLine("    , p.EmailID ");
            //sb.AppendLine("    , p.Gender ");
            //sb.AppendLine("    , p.AddressID ");
            //sb.AppendLine("    , a.Address ");
            //sb.AppendLine("    , a.City ");
            //sb.AppendLine("   , a.PostalCode ");
            //sb.AppendLine("    , po.ProvinceName ");
            //sb.AppendLine("    , po.ProvinceAbbreviation ");
            //sb.AppendLine("    FROM dbo.Person as p ");
            //sb.AppendLine(" Left Join Address as a ON a.AddressId = p.AddressID ");
            //sb.AppendLine(" Left Join Province as po ON po.ProvinceID = a.ProvinceID ");


            SqlConnection conn = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand(sb.ToString(), conn);

            //cmd.Parameters.AddWithValue("@userid", userId);
            conn.Open();
            SqlDataAdapter sa = new SqlDataAdapter(cmd);

            DataSet ds = new DataSet();

            try
            {
                sa.Fill(ds);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                conn.Close();
            }

           

            return ds;
        }
    }
}