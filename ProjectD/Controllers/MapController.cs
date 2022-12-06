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
    }
}
