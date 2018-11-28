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
        private readonly IMainRepository _mainRepository;

        public HomeController(IMainRepository mainRepository)
        {
            _mainRepository = mainRepository;
        }
        public ActionResult Index()
        {
            List<Product> model = _mainRepository.Products.ToList();
            return View(model);
        }

        public ActionResult Details()
        {
            return View();
        }
    }
}