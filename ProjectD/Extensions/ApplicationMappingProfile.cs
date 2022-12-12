﻿using AutoMapper;
using ProjectD.Data.Entities;
using ProjectD.Models.Event;
using ProjectD.Models.Map;

namespace ProjectD.Extensions
{
    public class ApplicationMappingProfile : Profile
    {
        public ApplicationMappingProfile()
        {
            CreateMap<Map, MapViewModel>();
            CreateMap<Event, EventViewModel>();
        }


    }
}
