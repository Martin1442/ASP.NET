using System;
using System.Collections.Generic;
using ToDo.Domain.Models;
using ToDo.DataAccess;
using System.Linq;

namespace ToDo.DataAccess.Repositories.CacheRepositories
{
    public class SubTaskRepository : IRepository<SubTask>
    {
        private ToDoDbContex _toDoDbContex;

        public SubTaskRepository(ToDoDbContex toDoDbContex)
        {
            _toDoDbContex = toDoDbContex;
        }

        public int Create(SubTask entity)
        {
            _toDoDbContex.SubTasks.Add(entity);

            return entity.Id;
        }

        public void Delete(int id)
        {
            SubTask subTask = _toDoDbContex.SubTasks.SingleOrDefault(x => x.Id == id);
            if(subTask != null)
            {
                _toDoDbContex.Remove(subTask);
            }
        }

        public List<SubTask> GetAll()
        {
            return _toDoDbContex.SubTasks.ToList();
        }

        public SubTask GetById(int id)
        {
            return _toDoDbContex.SubTasks.SingleOrDefault(x => x.Id == id);
        }

        public void Update(SubTask entity)
        {
            SubTask subTask = _toDoDbContex.SubTasks.FirstOrDefault(x => x.Id == entity.Id);
            if(subTask != null)
            {
                _toDoDbContex.SubTasks.Update(entity);
                _toDoDbContex.SaveChanges();
            }
        }
    }
}
