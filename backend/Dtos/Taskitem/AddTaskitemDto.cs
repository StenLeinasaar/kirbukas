using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace backend.Dtos.Taskitem{
    public class AddTaskitemDto {
        public string? TaskName { get; set; }
        public string? Description {get;set;}
    
    }
}