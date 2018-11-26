using Shopping.Domain.Abstracts;
using Shopping.Domain.Concetre;
using Shopping.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Shopping.Controllers
{
    public class HomeController : Controller
    {
        //private readonly IMainRepository mainRepository;
        public ActionResult Index()
        {
            //List<Product> model = mainRepository.Products.ToList();
            return View();
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