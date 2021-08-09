using MvcRestaurants.Filters;
using MvcRestaurants.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcRestaurants.Controllers
{
    public class HomeController : Controller
    {
        MvcRestaurantDb _db = new MvcRestaurantDb();
        public ActionResult Index()
        {
            var model = _db.Restaurants.ToList();
            return View(model);

        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            AboutModel ab = new AboutModel();
            ab.Name = "Anthology";
            ab.Location = "Bangalore";

            return View(ab);
        }

        
       
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            

            return View();
            
        }
    }
}