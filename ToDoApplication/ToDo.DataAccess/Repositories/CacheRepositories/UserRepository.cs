using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using ToDo.Domain.Models;

namespace ToDo.DataAccess.Repositories.CacheRepositories
{
    public class UserRepository : IRepository<User>
    {
        private ToDoDbContex _toDoDbContex;
        public UserRepository(ToDoDbContex toDoDbContex)
        {
            _toDoDbContex = toDoDbContex;
        }
        public int Create(User entity)
        {
            if (entity != null)
            {
                _toDoDbContex.Users.Add(entity);
                _toDoDbContex.SaveChanges();
            }
            
            return entity.Id;
        }

        public void Delete(int id)
        {
            User user = _toDoDbContex.Users.Include(x => x.ToDoTasks).SingleOrDefault(x => x.Id == id);
            if (user != null)
            {
                _toDoDbContex.Users.Remove(user);
                _toDoDbContex.SaveChanges();
            }
        }

        public List<User> GetAll()
        {
            return _toDoDbContex.Users.Include(x => x.ToDoTasks).ToList();
        }

        public User GetById(int id)
        {
            return _toDoDbContex.Users.SingleOrDefault(x => x.Id == id);
        }

        public void Update(User entity)
        {
            User user = _toDoDbContex.Users.SingleOrDefault(x => x.Id == entity.Id);
            if (user != null)
            {
                _toDoDbContex.Users.Update(entity);
                _toDoDbContex.SaveChanges();
            }
        }
    }
}
