using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SEDC.App.Models.DomainModels;

namespace SEDC.App.Controllers
{
    public class HomeController : Controller
    {
        public List<Pizza> _orderedPizza { get; set; }
        public HomeController()
        {
            Pizza _orderedPizza = new Pizza()
            {
                Id = 2,
                Name = "Peperoni",
                Size = PizzaSize.Large,
                Price = 7.0
            };
        }

        [Route("Begin")]
        public IActionResult Index()
        {
            
            return View();
        }

        [HttpGet("CallMe")]
        public ViewResult Contact()
        {
            return View();
        }

        public IActionResult Nothing()
        {
            return new EmptyResult();
        }

        public IActionResult BackToHome()
        {
            return RedirectToAction("Index");
        }

        public IActionResult JsonData()
        {
            object order = new { OrderId = 12, OrderName = "Zdrave" };
            return new JsonResult(order);
        }
        public IActionResult AboutUs()
        {
            return View();
        }

        public IActionResult Promotion()
        {
            ViewBag.Title = "Today's Promotion:";
            
            return View(_orderedPizza[0]);
        }
    }
}