using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using ToDo.DataAccess.Repositories;
using ToDo.DataAccess.Repositories.CacheRepositories;
using ToDo.Domain.Models;

namespace ToDo.Services.Helpers
{
    public static class DIRepositoryModule
    {
        public static IServiceCollection RegisterRepositories(IServiceCollection service)
        {
            service.AddTransient<IRepository<SubTask>, SubTaskRepository>();
            service.AddTransient<IRepository<Task>, TaskRepository>();
            service.AddTransient<IRepository<User>, UserRepository>();

            return service;

        }
    }
}
