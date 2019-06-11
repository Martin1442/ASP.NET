using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoApplication.Models.DomainModels
{
    public enum Status
    {
        NotDone,
        InProgress,
        Done
    }

    public enum Type
    {
        Work,
        Personal,
        Hobby
    }

    public enum Importance
    {
        Important = 1,
        MediumImportance = 2,
        NotImportant = 3
    }

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
