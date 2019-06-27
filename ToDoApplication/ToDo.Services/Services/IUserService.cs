using System;
using System.Collections.Generic;
using System.Text;
using ToDo.Domain.Models;

namespace ToDo.Services.Services
{
    public interface IUserService
    {
        User GetUserById(int id);
        int AddNewUser(User entity);
    }
}
