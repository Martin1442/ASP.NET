using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoApplication.Models.DomainModels.Enums;
using Type = ToDoApplication.Models.DomainModels.Enums.Type;

namespace ToDoApplication.Models.DomainModels
{
    public class Tasks
    {
        public string Title { get; set; }
        public string Descripton { get; set; }
        public Status Status { get; set; }
        public Type Type { get; set; }
        public List<SubTasks> SubTasks { get; set; } = new List<SubTasks>();
        public Importance Importance { get; set; }
    }
}
