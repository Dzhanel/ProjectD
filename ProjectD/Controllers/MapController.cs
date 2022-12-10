using Microsoft.AspNetCore.Mvc;
using ProjectD.Contracts;

namespace ProjectD.Controllers
{
    public class MapController : Controller
    {
        private readonly IMapService mapService;

        public MapController(
            IMapService _mapService
            )
        {
            mapService = _mapService;
        }

        public async Task<IActionResult> Index()
        {
            var maps = await mapService.AllMaps();
            ViewData["Title"] = "Maps";
            return View(maps);
        }

        public async Task<IActionResult> Details(string id)
        {
            Guid guid = Guid.Parse(id);
            var map = await mapService.GetMapById(guid);
            ViewData["Title"] = $"Details - {map.Name}";
            
            return View(map);
        }

        public async Task<IActionResult> Edit()
        {
            return View();
        }
    }
}
