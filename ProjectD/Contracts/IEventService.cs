using ProjectD.Models.Event;

namespace ProjectD.Contracts
{
    public interface IEventService
    {
        Task<IEnumerable<EventViewModel>> AllEvents();

        Task<EventViewModel> GetEventById(Guid guid);
    }
}
