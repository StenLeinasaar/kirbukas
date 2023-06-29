using System.ComponentModel.DataAnnotations;
using System;

namespace backend.Models{

    public class Taskitem{

        public int Id {get;set;}
        public string TaskName { get; set; } = "Take dog out";
        public string Description {get;set;}= "Go take a long walk with Sid";
    
    }
}