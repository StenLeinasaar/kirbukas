using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using backend.Dtos.Taskitem;
using backend.Models;

namespace backend{
    public class AutoMapperProfile: Profile {

        public AutoMapperProfile()
        {

            CreateMap<Taskitem, GetTaskitemDto>();
            
        }

    }
}