
using backend.Models;
using Microsoft.AspNetCore.Mvc;
using backend.Services.TaskService;
using backend.Dtos.Taskitem;

namespace backend.Controllers
{




    [ApiController]
    [Route("api/[Controller]")]
    public class TaskitemController : ControllerBase{

        private readonly ITaskitemService _taskitemService;

        public TaskitemController(ITaskitemService taskitemService)
        {
        _taskitemService = taskitemService;
        
        }

        [HttpGet("tasks")]
        public async Task<ActionResult<ServiceResponse<List<GetTaskitemDto>>>> GetAllTasks(){
        

            return Ok(await _taskitemService.GetAllTasks());
        }

    }


}