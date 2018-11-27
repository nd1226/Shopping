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

        public ActionResult Details()
        {
            return View();
        }
    }
}