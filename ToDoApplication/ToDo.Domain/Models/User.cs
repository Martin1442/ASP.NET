using System;
using System.Collections.Generic;
using System.Text;

namespace ToDo.Domain.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public double AverageFreeTime { get; set; }
        public List<Task> ToDoTasks { get; set; } = new List<Task>();
    }
}
