using System;
using System.Collections.Generic;
using System.Linq;
using ToDo.Domain.Models;

namespace ToDoApplication.Models
{
    public class HomeViewModel
    {
        public List<Task> UndoneTasks { get; set; } = new List<Task>();
    }
}
