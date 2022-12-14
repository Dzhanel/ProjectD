using AutoMapper;
using Microsoft.EntityFrameworkCore;
using ProjectD.Contracts;
using ProjectD.Data.Common;
using ProjectD.Data.Entities;
using ProjectD.Models.Event;
using ProjectD.Models.Map;

namespace ProjectD.Services
{
    public class MapService : IMapService
    {
        private readonly IRepository repo;
        private readonly IMapper mapper;
        private readonly IEventService eventService;
        public MapService(
            IRepository _repo,
            IMapper _mapper,
            IEventService _eventService)
        {
            this.repo = _repo;
            this.mapper = _mapper;
            this.eventService = _eventService;
        }

        public async Task<IEnumerable<MapViewModel>> AllMaps()
        {
            return await repo.AllReadonly<Map>()
                .Select(m => mapper.Map<MapViewModel>(m))
                .ToListAsync();
        }

        public async Task<MapViewModel> GetMapById(Guid mapId)
        {
            var map = await repo.GetByIdAsync<Map>(mapId);

            var model = mapper.Map<MapViewModel>(map);

            model.Events = (await repo.AllReadonly<Event>()
                    .Where(e => e.MapId == map.Id)
                    .ToListAsync())
                    .Select(e => mapper.Map<EventViewModel>(e))
                    .ToList();               

            return model;
        }
    }
}