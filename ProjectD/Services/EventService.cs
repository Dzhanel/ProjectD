using AutoMapper;
using Microsoft.EntityFrameworkCore;
using ProjectD.Contracts;
using ProjectD.Data.Common;
using ProjectD.Data.Entities;
using ProjectD.Models.Event;

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
                .Select(e => mapper.Map<EventViewModel>(e))
                .ToListAsync();
        }

        public async Task<EventViewModel> GetEventById(Guid guid)
        {
            var _event = await repo.GetByIdAsync<Event>(guid);

            return this.mapper.Map<EventViewModel>(_event);

        }
    }
}
