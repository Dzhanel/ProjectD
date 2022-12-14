using AutoMapper;
using ProjectD.Data.Entities;
using ProjectD.Models.Event;
using ProjectD.Models.Map;
using ProjectD.Models.Racer;

namespace ProjectD.Extensions
{
    public class ApplicationMappingProfile : Profile
    {
        public ApplicationMappingProfile()
        {
            CreateMap<Map, MapViewModel>();
            CreateMap<Event, EventViewModel>()
                .ForMember(dest => dest.EventDate, opt => opt.MapFrom(src => src.EventDate.ToString("dd.MM.yyyy HH:mm")));
            CreateMap<Racer, RacerViewModel>();
                

        }


    }
}
