using System;
using System.Collections.Generic;
using System.Linq;
using ToDo.Domain.Models;

namespace ToDo.DataAccess.Repositories.CacheRepositories
{
    public class TaskRepository : IRepository<Task>
    {
        public int Create(Task entity)
        {
            CacheDb.TasksId++;
            entity.Id = CacheDb.TasksId;
            CacheDb.Tasks.Add(entity);

            return entity.Id;
        }

        public void Delete(int id)
        {
            Task task = CacheDb.Tasks.FirstOrDefault(x => x.Id == id);
            if (task != null)
            {
                CacheDb.Tasks.Remove(task);
            }
        }

        public List<Task> GetAll()
        {
            return CacheDb.Tasks;
        }

        public Task GetById(int id)
        {
            return CacheDb.Tasks.FirstOrDefault(x => x.Id == id);
        }

        public void Update(Task entity)
        {
            Task task = CacheDb.Tasks.FirstOrDefault(x => x.Id == entity.Id);
            if (task != null)
            {
                int index = CacheDb.Tasks.IndexOf(task);
                CacheDb.Tasks[index] = entity;
               
            }
        }
    }
}
