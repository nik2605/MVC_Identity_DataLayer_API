using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Identity_DataLayer.Mapper;
using MVC_Identity_DataLayer.Models;
using MVC_Identity_DataLayer_Data;

namespace MVC_Identity_DataLayer.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Person person = new Person();

            var personModel = person.GetPersons().Map();
            var model = new User().GetUser(1).Map();
            return View(model);
        }

        [HttpDelete]
        public ActionResult DeleteUser( int userId)
        {
            //todo delete user
            return null;
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}