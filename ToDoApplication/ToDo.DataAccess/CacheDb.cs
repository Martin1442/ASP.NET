using System;
using System.Collections.Generic;
using System.Text;
using ToDo.Domain.Enums;
using ToDo.Domain.Models;
using Type = ToDo.Domain.Enums.Type;

namespace ToDo.DataAccess
{
    public static class CacheDb
    {
        public static List<Task> Tasks { get; set; }
        public static List<User> Users { get; set; }
        public static List<SubTask> SubTasks { get; set; }
        public static int TasksId;
        public static int UsersId;
        public static int SubTasksId;

        static CacheDb()
        {
            SubTasks = new List<SubTask>
            {

            };

            Tasks = new List<Task>()
            {
                new Task
                {
                    Id = 1,
                    Title = "Gym",
                    Descripton = "Chest day",
                    Importance = Importance.Medium,
                    Status = Status.NotDone,
                    Type = Type.Hobby,

                },
                new Task
                {
                    Id = 2,
                    Title = "Lozje Day",
                    Descripton = "Kopanje",
                    Importance = Importance.Medium,
                    Status = Status.Done,
                    Type = Type.Personal,
                },
                new Task
                {
                    Id = 3,
                    Title = "SEDC Homework",
                    Descripton = "Doing Homework",
                    Importance = Importance.Important,
                    Status = Status.InProgress,
                    Type = Type.Personal
                },
                new Task
                {
                    Id = 4,
                    Title = "Gym",
                    Descripton = "Leg day",
                    Importance = Importance.Important,
                    Status = Status.Done,
                    Type = Type.Hobby,

                },
                new Task
                {
                    Id = 5,
                    Title = "C#",
                    Descripton = "Programing",
                    Importance = Importance.Important,
                    Status = Status.Done,
                    Type = Type.Personal,
                },
                new Task
                {
                    Id = 6,
                    Title = "SEDC Homework",
                    Descripton = "C# Homework",
                    Importance = Importance.Important,
                    Status = Status.InProgress,
                    Type = Type.Personal
                },
                new Task
                {
                    Id = 7,
                    Title = "Resting",
                    Descripton = "Day for resting",
                    Importance = Importance.NotImportant,
                    Status = Status.NotDone,
                    Type = Type.Personal,

                },
                new Task
                {
                    Id = 8,
                    Title = "Crossfit",
                    Descripton = "Working out",
                    Importance = Importance.Medium,
                    Status = Status.NotDone,
                    Type = Type.Hobby,
                },
                new Task
                {
                    Id = 9,
                    Title = "SEDC",
                    Descripton = "Going on class",
                    Importance = Importance.Important,
                    Status = Status.InProgress,
                    Type = Type.Personal
                }
            };

            Users = new List<User>()
            {
                new User()
                {
                    Id = 1,
                    FirstName = "John",
                    LastName = "Doe",
                    Age = 99,
                    AverageFreeTime = 9,
                    ToDoTasks = new List<Task>(){Tasks[0], Tasks[3]}
                },
                new User()
                {
                    Id = 2,
                    FirstName = "Jane",
                    LastName = "Doe",
                    Age = 99,
                    AverageFreeTime = 9,
                    ToDoTasks = new List<Task>(){Tasks[1], Tasks[2]}
                },
            };

            TasksId = 9;
            UsersId = 2;
            SubTasksId = 0;
        }
    }
}
