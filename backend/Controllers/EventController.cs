
using ToDoApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace ToDoApp.Controllers{

    
    [ApiController]
    [Route("api/[Controller]")]
    public class TaskController : ControllerBase{

        [HttpGet("tasks")]
        public IActionResult GetAllTasks(){
        

            return Ok();
        }

    }


}