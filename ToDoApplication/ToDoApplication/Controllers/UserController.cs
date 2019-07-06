using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ToDo.DataAccess.Repositories;
using ToDo.Domain.Models;
using ToDo.Services.Services;

namespace ToDoApplication.Controllers
{
    [Route("User/[action]")]
    public class UserController : Controller
    {
        private ITasksService _taskRepository;
        private IUserService _userRepository;

        public UserController(ITasksService taskRepository, IUserService userRepository)
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