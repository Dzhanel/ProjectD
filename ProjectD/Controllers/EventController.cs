using Microsoft.AspNetCore.Mvc;
using ProjectD.Contracts;

namespace ProjectD.Controllers
{
    public class EventController : Controller
    {
        private readonly IEventService eventService;

        public EventController(IEventService eventService)
        {
            this.eventService = eventService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var events = await eventService.AllEvents();
            ViewData["Title"] = "Events";
            return View(events);
        }

        [HttpGet]
        public async Task<IActionResult> Details(string id)
        {
            Guid guid = Guid.Parse(id);
            var _event = await eventService.GetEventById(guid);
            ViewData["Title"] = $"Details: {_event.Title}";

            return View(_event);
        }
    }
}
