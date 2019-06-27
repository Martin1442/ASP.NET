using System.Collections.Generic;
using System.Linq;
using ToDo.Domain.Models;

namespace ToDo.DataAccess.Repositories.CacheRepositories
{
    public class UserRepository : IRepository<User>
    {
        public int Create(User entity)
        {
            CacheDb.UsersId++;
            entity.Id = CacheDb.UsersId;
            CacheDb.Users.Add(entity);

            return entity.Id;
        }

        public void Delete(int id)
        {
            User user = CacheDb.Users.FirstOrDefault(x => x.Id == id);
            if (user != null)
            {
                CacheDb.Users.Remove(user);
            }
        }

        public List<User> GetAll()
        {
            return CacheDb.Users;
        }

        public User GetById(int id)
        {
            return CacheDb.Users.FirstOrDefault(x => x.Id == id);
        }

        public void Update(User entity)
        {
            User user = CacheDb.Users.FirstOrDefault(x => x.Id == entity.Id);
            if (user != null)
            {
                int index = CacheDb.Users.IndexOf(user);
                CacheDb.Users[index] = entity;
            }
        }
    }
}
