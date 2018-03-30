using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace angmvc.Controllers
{
    public class Customer
    {
        public string title { get; set; }
        public string country { get; set; }

    }

    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View("Index");
        }

        public ActionResult Login()
        {
            return View("Login");
        }

        public ActionResult Dashboard()
        {
            return View("Dashboard");
        }

        public ActionResult GetCustomers()
        {
            List<Customer> customer = new List<Customer>();
            customer.Add(new Customer { title = "Customer1", country = "UK" });
            customer.Add(new Customer { title = "Customer2", country = "India" });
            customer.Add(new Customer { title = "Customer3", country = "USA" });

            return Json(new { customers = customer }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult WorkArea()
        {
            return View("WorkArea");
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