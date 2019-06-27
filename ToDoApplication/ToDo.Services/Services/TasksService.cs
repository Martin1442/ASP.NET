using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ToDo.DataAccess;
using ToDo.DataAccess.Repositories;
using ToDo.Domain.Models;

namespace ToDo.Services.Services
{
    public class TasksService : ITasksService
    {
        private IRepository<Task> _taskRepository;
        private IRepository<SubTask> _subTaskRepository;

        public TasksService(IRepository<Task> taskRepository, IRepository<SubTask> subTaskRepository)
        {
            _taskRepository = taskRepository;
            _subTaskRepository = subTaskRepository;
        }

        public void CreateNewTask(Task task)
        {
            _taskRepository.Create(task);
        }

        public List<Task> GetAllTasks()
        {
            return _taskRepository.GetAll();
        }

        public Task GetTaskById(int id)
        {
            return _taskRepository.GetById(id);
        }

        public int GetTaskCount()
        {
            return _taskRepository.GetAll().Count();
        }

        public List<SubTask> GetAllSubTasks()
        {
            return _subTaskRepository.GetAll();
        }

        public SubTask GetSubTaskById(int id)
        {
            return _subTaskRepository.GetById(id);
        }

        public void CreateNewSubTask(SubTask subTask)
        {
            _subTaskRepository.Create(subTask);
        }
    }
}
