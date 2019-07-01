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
                new SubTask
                {
                    Id = 1,
                    TaskId = 1,
                    Title = "Nap",
                    Description = "1h Nap",
                    Status = false
                },
                new SubTask
                {
                    Id = 2,
                    TaskId = 3,
                    Title = "TV",
                    Description = "Watching Basketball",
                    Status = true
                },
                new SubTask
                {
                    Id = 3,
                    TaskId = 2,
                    Title = "PC",
                    Description = "Playing Fortnite",
                    Status = false
                },
                new SubTask
                {
                    Id = 4,
                    TaskId = 4,
                    Title = "PC",
                    Description = "Playing DOTA",
                    Status = false
                },
                new SubTask
                {
                    Id = 5,
                    TaskId = 5,
                    Title = "Youtiube",
                    Description = "Listening Music",
                    Status = false
                }

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
                    SubTasks = new List<SubTask>(){SubTasks[0]}
                },
                new Task
                {
                    Id = 2,
                    Title = "Lozje Day",
                    Descripton = "Kopanje",
                    Importance = Importance.Medium,
                    Status = Status.Done,
                    Type = Type.Personal,
                    SubTasks = new List<SubTask>(){SubTasks[1]}
                },
                new Task
                {
                    Id = 3,
                    Title = "SEDC Homework",
                    Descripton = "Doing Homework",
                    Importance = Importance.Important,
                    Status = Status.InProgress,
                    Type = Type.Personal,
                    SubTasks = new List<SubTask>(){SubTasks[2]}
                },
                new Task
                {
                    Id = 4,
                    Title = "Gym",
                    Descripton = "Leg day",
                    Importance = Importance.Important,
                    Status = Status.Done,
                    Type = Type.Hobby,
                    SubTasks = new List<SubTask>(){SubTasks[3]}
                },
                new Task
                {
                    Id = 5,
                    Title = "C#",
                    Descripton = "Programing",
                    Importance = Importance.Important,
                    Status = Status.Done,
                    Type = Type.Personal,
                    SubTasks = new List<SubTask>(){SubTasks[4]}
                },
                new Task
                {
                    Id = 6,
                    Title = "SEDC Homework",
                    Descripton = "C# Homework",
                    Importance = Importance.Important,
                    Status = Status.InProgress,
                    Type = Type.Personal,
                    SubTasks = new List<SubTask>(){ }
                },
                new Task
                {
                    Id = 7,
                    Title = "Resting",
                    Descripton = "Day for resting",
                    Importance = Importance.NotImportant,
                    Status = Status.NotDone,
                    Type = Type.Personal,
                    SubTasks = new List<SubTask>(){ }
                },
                new Task
                {
                    Id = 8,
                    Title = "Crossfit",
                    Descripton = "Working out",
                    Importance = Importance.Medium,
                    Status = Status.NotDone,
                    Type = Type.Hobby,
                    SubTasks = new List<SubTask>(){ }
                },
                new Task
                {
                    Id = 9,
                    Title = "SEDC",
                    Descripton = "Going on class",
                    Importance = Importance.Important,
                    Status = Status.InProgress,
                    Type = Type.Personal,
                    SubTasks = new List<SubTask>(){ }
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
                    ToDoTasks = new List<Task>(){Tasks[0], Tasks[3], Tasks[4], Tasks[6], Tasks[8]}
                },
                new User()
                {
                    Id = 2,
                    FirstName = "Jane",
                    LastName = "Doe",
                    Age = 99,
                    AverageFreeTime = 9,
                    ToDoTasks = new List<Task>(){Tasks[1], Tasks[2], Tasks[5], Tasks[7]}
                },
            };

            TasksId = 9;
            UsersId = 2;
            SubTasksId = 5;
        }
    }
}
