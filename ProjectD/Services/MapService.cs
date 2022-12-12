using AutoMapper;
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
        private readonly IMapper mapper;
        public MapService(
            IRepository _repo,
            IMapper mapper)
        {
            this.repo = _repo;
            this.mapper = mapper;
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

            return this.mapper.Map<MapViewModel>(map);
        }
    }
}