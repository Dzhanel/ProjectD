using ProjectD.Models.Map;

namespace ProjectD.Contracts
{
    public interface IMapService
    {
        Task<IEnumerable<MapServiceModel>> AllMaps();
    }
}