using System;
using System.Collections.Generic;
using ToDo.Domain.Models;
using ToDo.DataAccess;
using System.Linq;

namespace ToDo.DataAccess.Repositories.CacheRepositories
{
    public class SubTaskRepository : IRepository<SubTask>
    {
        public int Create(SubTask entity)
        {
            CacheDb.SubTasksId++;
            entity.Id = CacheDb.SubTasksId;
            CacheDb.SubTasks.Add(entity);

            return entity.Id;
        }

        public void Delete(int id)
        {
            SubTask subTask = CacheDb.SubTasks.FirstOrDefault(x => x.Id == id);
            if(subTask != null)
            {
                CacheDb.SubTasks.Remove(subTask);
            }
        }

        public List<SubTask> GetAll()
        {
            return CacheDb.SubTasks;
        }

        public SubTask GetById(int id)
        {
            return CacheDb.SubTasks.FirstOrDefault(x => x.Id == id);
        }

        public void Update(SubTask entity)
        {
            SubTask subTask = CacheDb.SubTasks.FirstOrDefault(x => x.Id == entity.Id);
            if(subTask != null)
            {
                int index = CacheDb.SubTasks.IndexOf(subTask);
                CacheDb.SubTasks[index] = entity;
            }
        }
    }
}
