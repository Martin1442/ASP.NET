using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using ToDo.Domain.Models;

namespace ToDo.DataAccess.Repositories.CacheRepositories
{
    public class TaskRepository : IRepository<Task>
    {
        private ToDoDbContex _toDoDbContex;

        public TaskRepository(ToDoDbContex toDoDbContex)
        {
            _toDoDbContex = toDoDbContex;
        }

        public int Create(Task entity)
        {
            if (entity != null)
            {
                _toDoDbContex.Add(entity);
                _toDoDbContex.SaveChanges();
                return entity.Id;
            }
            return 0;
        }

        public void Delete(int id)
        {
            Task task = _toDoDbContex.Tasks
                .Include(x => x.SubTasks)
                .SingleOrDefault(x => x.Id == id);

            if (task != null)
            {
                _toDoDbContex.Tasks.Remove(task);
                _toDoDbContex.SaveChanges();
            }
        }

        public List<Task> GetAll()
        {
            return _toDoDbContex.Tasks.Include(x => x.SubTasks).ToList();
        }

        public Task GetById(int id)
        {
            return _toDoDbContex.Tasks.Include(x => x.SubTasks).SingleOrDefault(x => x.Id == id);
        }

        public void Update(Task entity)
        {
            Task task = _toDoDbContex.Tasks.SingleOrDefault(x => x.Id == entity.Id);
            if (task != null)
            {
                task.UserId = entity.UserId;
                task.Title = entity.Title;
                task.Descripton = entity.Descripton;
                task.Importance = entity.Importance;
                task.Status = entity.Status;
                task.Type = entity.Type;
                _toDoDbContex.Tasks.Update(task);
                _toDoDbContex.SaveChanges();
            }
        }
    }
}
