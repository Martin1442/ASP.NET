using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SEDC.App.Models.DomainModels;
using SEDC.App.Models.ViewModels;

namespace SEDC.App.Controllers
{   
    
    public class OrderController : Controller
    {
        private List<Order> _orderDB;

        public OrderController()
        {
            User bob = new User()
            {
                Id = 12,
                FirstName = "Bob",
                LastName = "Bobsky",
                Address = "Bob Street",
                Phone = 091288211
            };
            User jill = new User()
            {
                FirstName = "Jill",
                LastName = "Wayne",
                Address = "Jill Street",
                Phone = 08006546345
            };
            _orderDB = new List<Order>() {
                new Order()
                {
                    Id = 1,
                    User = bob,
                    Pizza = new Pizza(){ Id = 2,Name="Kapri",Size = PizzaSize.ExtraLarge , Price = 10.5}
                },
                new Order()
                {
                    Id = 2,
                    User = bob,
                    Pizza = new Pizza(){ Id = 2,Name="Vegetariana",Size = PizzaSize.Medium , Price = 5.5}
                },
                new Order()
                {
                    Id = 3,
                    User = jill,
                    Pizza = new Pizza(){ Id = 2,Name="Peperoni",Size = PizzaSize.Small , Price = 3.5},
                }
            };
        }

        [Route("Orders")]
        public IActionResult Index()
        {
            //ViewData.Add("Title", "Welcome to the Orders page");
            ViewBag.Title = "Welcome to the Orders page";
            //Order firstOrder = _orderDB[0];
            //OrdersViewModel ordersViewModel = new OrdersViewModel()
            //{
            //    FirstPizza = firstOrder.Pizza.Name,
            //    NumberOfOrders = _orderDB.Count(),
            //    FirstPersonName = $"{firstOrder.User.FirstName} {firstOrder.User.LastName}"
            //};
            
            return View(_orderDB);
        }

        public IActionResult Details(int? id)
        {
            //ViewData.Add("Title", "These are your orders:");
            try
            {
                Order order = _orderDB.Find(x => x.Id == id);
                ViewBag.Title = $"This is order no.{order.Id}";
                if (order != null) return View(order);
            }
            catch (Exception)
            {
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }
    }
}