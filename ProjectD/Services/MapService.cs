using Microsoft.EntityFrameworkCore;
using ProjectD.Contracts;
using ProjectD.Data.Common;
using ProjectD.Data.Entities;
using ProjectD.Models.Map;

namespace ProjectD.Services
{
    public class MapService : IMapService
    {
        private readonly IRepository repo;
        
        private readonly ILogger logger;

        public MapService(
            IRepository _repo,
            ILogger<MapService> _logger)
        {
            repo = _repo;
            logger = _logger;
        }


        public async Task<IEnumerable<MapServiceModel>> AllMaps()
        {
            return await repo.AllReadonly<Map>()
                .Select(p => new MapServiceModel()
                {
                    Id = p.Id,
                    Name = p.Name,
                    StartLongitude = p.StartLongitude,
                    SartLatitude = p.SartLatitude,
                    FinishLatitude = p.FinishLatitude,
                    FinishLongitude = p.FinishLongitude,
                    LengthKm = p.LengthKm,
                    BestTime = p.BestTime
                }).ToListAsync();

        }
    }
}
