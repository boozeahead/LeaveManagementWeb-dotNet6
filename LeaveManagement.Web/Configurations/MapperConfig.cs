﻿using AutoMapper;
using LeaveManagement.Web.Data;
using LeaveManagement.Web.Models;

namespace LeaveManagement.Web.Configurations
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            // Mapping Configuration
            CreateMap<LeaveType, LeaveTypeVM>().ReverseMap();
        }
    }
}
