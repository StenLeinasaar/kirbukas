using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using backend.Dtos.Taskitem;
using backend.Models;


namespace backend.Services.TaskService{

    public class TaskitemService: ITaskitemService{

        private readonly IMapper _mapper;

        private List<GetTaskitemDto> taskitems;

        public TaskitemService(IMapper mapper){
            _mapper = mapper;
        }
        
    
        

        public async Task<ServiceResponse<List<GetTaskitemDto>>> GetAllTasks()
        {
            var serviceResponse = new ServiceResponse<List<GetTaskitemDto>>();
            serviceResponse.Data = taskitems;
        
            return serviceResponse;
        }
    }
}