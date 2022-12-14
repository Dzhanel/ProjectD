using AutoMapper;
using Microsoft.EntityFrameworkCore;
using ProjectD.Contracts;
using ProjectD.Data.Common;
using ProjectD.Data.Entities;
using ProjectD.Models.Event;
using ProjectD.Models.Racer;

namespace ProjectD.Services
{
    public class EventService : IEventService
    {
        private readonly IRepository repo;
        private readonly IMapper mapper;
        public EventService(
            IRepository _repo,
            IMapper _mapper)
        {
            this.repo = _repo;
            this.mapper = _mapper;
        }
        public async Task<IEnumerable<EventViewModel>> AllEvents()
        {
            return await repo.AllReadonly<Event>()
                .Include(e => e.Map)
                .Include(r => r.Racers)
                .Select(e => mapper.Map<EventViewModel>(e))
                .ToListAsync();
        }

        public async Task<EventViewModel> GetEventById(Guid guid)
        {
            var carEvent = await repo.GetByIdAsync<Event>(guid);
            
            carEvent.Map = await repo.GetByIdAsync<Map>(carEvent.MapId);
            

            var eventRacers = await repo.AllReadonly<Racer>()
                .Where(r => 
                    r.Events.Any(e => e.Id == carEvent.Id))
                .Include(r => r.User)
                .ToListAsync();

            var model = mapper.Map<EventViewModel>(carEvent);

            model.Racers = eventRacers
                .Select(e => mapper.Map<RacerViewModel>(e)).ToList();

            return model;

        }
    }
}
