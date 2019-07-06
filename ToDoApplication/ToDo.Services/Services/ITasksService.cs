using System;
using System.Collections.Generic;
using System.Text;
using ToDo.Domain.Models;

namespace ToDo.Services.Services
{
    public interface ITasksService
    {
        List<Task> GetAllTasks();
        Task GetTaskById(int id);
        int GetTaskCount();
        void UpdateTask(Task task);
        void CreateNewTask(Task task);
        List<SubTask> GetAllSubTasks();
        SubTask GetSubTaskById(int id);
        void CreateNewSubTask(SubTask subTask);
    }
}
