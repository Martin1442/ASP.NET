using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoApplication.Models.DomainModels
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public double AverageFreeTime { get; set; }
        public List<Tasks> ToDoTasks { get; set; } = new List<Tasks>();
    }
}
