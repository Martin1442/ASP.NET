using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ToDo.DataAccess;
using ToDo.Domain.Enums;
using ToDo.Domain.Models;
using ToDo.Services.Services;
using ToDoApplication.Models;

namespace ToDoApplication.Controllers
{
    public class HomeController : Controller
    {
        private ITasksService _tasks;

        public HomeController(ITasksService tasks)
        {
            _tasks = tasks;
        }

        public IActionResult Index()
        {
            List<Task> tasks = _tasks.GetAllTasks();
            List<Task> undoneTaskss = new List<Task>();
            foreach (var task in tasks)
            {
                if(task.Status != Status.Done)
                {
                    undoneTaskss.Add(task);
                }
            };

            HomeViewModel model = new HomeViewModel()
            {
                UndoneTasks = undoneTaskss,
            };

            return View(model);
        }

        public IActionResult About()
        {
            ViewBag.Title = "Something About Us";
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

    }
}
