using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ToDo.DataAccess.Repositories;
using ToDo.Domain.Models;

namespace ToDoApplication.Controllers
{
    [Route("User/[action]")]
    public class UserController : Controller
    {
        IRepository<Task> _taskRepository;
        IRepository<User> _userRepository;

        public UserController(IRepository<Task> taskRepository, IRepository<User> userRepository)
        {
            _taskRepository = taskRepository;
            _userRepository = userRepository;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult InProgress()
        {

            return View();
        }

        public IActionResult NotDone()
        {
            return View();
        }

        public IActionResult Done()
        {
            return View();
        }
        public IActionResult Statistics()
        {
            return View();
        }
    }
}