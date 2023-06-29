using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend.Dtos.Taskitem;
using backend.Models;

namespace backend.Services.TaskService{

    public interface ITaskitemService{
        Task <ServiceResponse<List<GetTaskitemDto>>> GetAllTasks();
        // Task GetTaskById(int id);
        // Task AddNewTask( Task task);

    }
}