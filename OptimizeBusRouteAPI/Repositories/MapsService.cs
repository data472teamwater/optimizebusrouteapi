using OptimizeBusRouteAPI.Data;
using OptimizeBusRouteAPI.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace OptimizeBusRouteAPI.Repositories
{
    public class MapsService : IMapsService
    {
        private readonly DbContextClass _dbContext;

        public MapsService(DbContextClass dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<TripData>> GetTripData(string Id)
        {
            var param = new SqlParameter("@RouteId", Id);
            var RouteDetails = await Task.Run(() => _dbContext.Trips.FromSqlRaw(@"exec SpGetTripsByID @RouteId", param).ToListAsync());
            return RouteDetails;
        }
    }
}
