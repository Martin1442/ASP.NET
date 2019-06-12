using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ToDoApplication.Models.DomainModels;
using ToDoApplication.Models.DomainModels.Enums;
using Type = ToDoApplication.Models.DomainModels.Enums.Type;

namespace ToDoApplication.Controllers
{
    [Route("User/[action]")]
    public class UserController : Controller
    {
        private List<User> _usersDb;
        private List<Tasks> _tasksDb;


        public UserController()
        {
            

            _tasksDb = new List<Tasks>()
            {
                new Tasks
                {
                    Title = "Gym",
                    Descripton = "Chest day",
                    Importance = Importance.MediumImportance,
                    Status = Status.NotDone,
                    Type = Type.Hobby,

                },
                new Tasks
                {
                    Title = "Lozje Day",
                    Descripton = "Kopanje",
                    Importance = Importance.MediumImportance,
                    Status = Status.Done,
                    Type = Type.Personal,
                },
                new Tasks
                {
                    Title = "SEDC Homework",
                    Descripton = "Doing Homework",
                    Importance = Importance.Important,
                    Status = Status.InProgress,
                    Type = Type.Personal
                }
            };

            _usersDb = new List<User>()
            {
                new User()
                {
                FirstName = "John",
                LastName = "Doe",
                Age = 99,
                AverageFreeTime = 9,
                ToDoTasks = _tasksDb
                },
                new User()
                {
                FirstName = "Jane",
                LastName = "Doe",
                Age = 99,
                AverageFreeTime = 9,
                ToDoTasks = _tasksDb
                },
            };
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
            var user = _usersDb[0];
            return View(user);
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