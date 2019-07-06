using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ToDo.Domain.Enums;
using Type = ToDo.Domain.Enums.Type;

namespace ToDo.Domain.Models
{
    public class Task
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int UserId { get; set; }
        
        public User User { get; set; }
        public string Title { get; set; }
        public string Descripton { get; set; }
        public Status Status { get; set; }
        public Type Type { get; set; }
        public List<SubTask> SubTasks { get; set; }
        public Importance Importance { get; set; }
    }
}
