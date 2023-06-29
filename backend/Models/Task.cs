using System.ComponentModel.DataAnnotations;
using System;

namespace ToDoApp.Models{

    public class User{

        public Guid Id {get;set;}
        public string? TaskName { get; set; }
        public string? Description {get;set;}
    
    }
}