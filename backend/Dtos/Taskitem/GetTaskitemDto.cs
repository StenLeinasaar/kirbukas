using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace backend.Dtos.Taskitem{
    public class GetTaskitemDto {
        public int Id {get;set;}
        public string? TaskName { get; set; }
        public string? Description {get;set;}
    
    }
}