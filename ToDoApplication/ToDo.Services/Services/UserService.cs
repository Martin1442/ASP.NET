using System;
using System.Collections.Generic;
using System.Text;
using ToDo.DataAccess.Repositories;
using ToDo.Domain.Models;

namespace ToDo.Services.Services
{
    public class UserService : IUserService
    {
        IRepository<User> _userRepository;
        public UserService(IRepository<User> userRepository)
        {
            _userRepository = userRepository;
        }

        public int AddNewUser(User entity)
        {
            return _userRepository.Create(entity);
        }

        public User GetUserById(int id)
        {
            return _userRepository.GetById(id);
        }
    }
}
