using ToDoApp.Service;
using ToDoApp.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace ChatApp.Controllers{

    [Route("api/[Controller]")]
    [ApiController]

    public class ChatController : ControllerBase{
        private readonly TaskService _taskService;

        public ChatController(TaskService taskService){
            _taskService = chatService;

        }

        [HttpGet("tasks")]

        public IActionResult GetAllTasks(Task model){
            if(_chatService.AddUserToList(model.Name)){
                //204 status code
                return NoContent();
            }

            return BadRequest("This name is taken, please choose another name");
        }

    }


}