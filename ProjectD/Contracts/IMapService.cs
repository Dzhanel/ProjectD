using ProjectD.Models.Map;

namespace ProjectD.Contracts
{
    public interface IMapService
    {
        Task<IEnumerable<MapViewModel>> AllMaps();

        Task<MapViewModel> GetMapById(Guid id);
    }
}