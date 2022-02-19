using System.Web;
using System.Web.Mvc;

namespace MVC_Identity_DataLayer_API
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
