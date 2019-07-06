using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;
using ToDo.Domain.Enums;
using ToDo.Domain.Models;
using Type = ToDo.Domain.Enums.Type;

namespace ToDo.DataAccess
{
    public class ToDoDbContex : DbContext
    {
        public ToDoDbContex()
        {

        }
        public ToDoDbContex(DbContextOptions<ToDoDbContex> options) : base(options)
        {
                
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=MARTINVITANOV-P\\MARTIN;Database=ToDoDb;Trusted_Connection=True");
            }
        }

        public DbSet<Task> Tasks { get; set; }
        public DbSet<SubTask> SubTasks { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Task>()
                .HasMany(x => x.SubTasks)
                .WithOne(x => x.Task)
                .HasForeignKey(x => x.TaskId);

            modelBuilder.Entity<User>()
                .HasMany(x => x.ToDoTasks)
                .WithOne(x => x.User)
                .HasForeignKey(x => x.UserId);

            modelBuilder.Entity<SubTask>()
                .HasData(
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
                });

            modelBuilder.Entity<Task>()
                .HasData(
                new Task
                {
                    Id = 1,
                    UserId = 1,
                    Title = "Gym",
                    Descripton = "Chest day",
                    Importance = Importance.Medium,
                    Status = Status.NotDone,
                    Type = Type.Hobby
                },
                new Task
                {
                    Id = 2,
                    UserId = 2,
                    Title = "Lozje Day",
                    Descripton = "Kopanje",
                    Importance = Importance.Medium,
                    Status = Status.Done,
                    Type = Type.Personal
                },
                new Task
                {
                    Id = 3,
                    UserId = 1,
                    Title = "SEDC Homework",
                    Descripton = "Doing Homework",
                    Importance = Importance.Important,
                    Status = Status.InProgress,
                    Type = Type.Personal
                },
                new Task
                {
                    Id = 4,
                    UserId = 1,
                    Title = "Gym",
                    Descripton = "Leg day",
                    Importance = Importance.Important,
                    Status = Status.Done,
                    Type = Type.Hobby
                },
                new Task
                {
                    Id = 5,
                    UserId = 2,
                    Title = "C#",
                    Descripton = "Programing",
                    Importance = Importance.Important,
                    Status = Status.Done,
                    Type = Type.Personal
                },
                new Task
                {
                    Id = 6,
                    UserId = 2,
                    Title = "SEDC Homework",
                    Descripton = "C# Homework",
                    Importance = Importance.Important,
                    Status = Status.InProgress,
                    Type = Type.Personal
                },
                new Task
                {
                    Id = 7,
                    UserId = 1,
                    Title = "Resting",
                    Descripton = "Day for resting",
                    Importance = Importance.NotImportant,
                    Status = Status.NotDone,
                    Type = Type.Personal
                },
                new Task
                {
                    Id = 8,
                    UserId = 1,
                    Title = "Crossfit",
                    Descripton = "Working out",
                    Importance = Importance.Medium,
                    Status = Status.NotDone,
                    Type = Type.Hobby
                },
                new Task
                {
                    Id = 9,
                    UserId = 2,
                    Title = "SEDC",
                    Descripton = "Going on class",
                    Importance = Importance.Important,
                    Status = Status.InProgress,
                    Type = Type.Personal
                });
            modelBuilder.Entity<User>()
                .HasData(new User()
                {
                    Id = 1,
                    FirstName = "John",
                    LastName = "Doe",
                    Age = 99,
                    AverageFreeTime = 9
                },
                new User()
                {
                    Id = 2,
                    FirstName = "Jane",
                    LastName = "Doe",
                    Age = 99,
                    AverageFreeTime = 9
                });
        }
    }
}
