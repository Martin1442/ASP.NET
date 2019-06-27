using System;
using System.Collections.Generic;
using System.Text;

namespace ToDo.DataAccess.Repositories
{
    public interface IRepository<T>
    {
        //CRUD methods

        T GetById(int id);
        List<T> GetAll();
        int Create(T entity);
        void Update(T entity);
        void Delete(int id);
    }
}
