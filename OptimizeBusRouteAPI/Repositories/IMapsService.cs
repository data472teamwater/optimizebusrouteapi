using OptimizeBusRouteAPI.Entities;

namespace OptimizeBusRouteAPI.Repositories
{
    public interface IMapsService
    {
        public Task<IEnumerable<TripData>> GetTripData(string Id);
    }
}
