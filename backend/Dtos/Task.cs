using System.ComponentModel.DataAnnotations;
using System;

namespace ToDoApp.Dtos{

    public class User{

        public Guid Id {get;set;}
        public string TaskName { get; set; }
        public string Description {get;set;}
    
    }
}