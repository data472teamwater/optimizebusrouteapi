using OptimizeBusRouteAPI.Entities;
using OptimizeBusRouteAPI.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace OptimizeBusRouteAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MapsController : Controller
    {
        private readonly IMapsService mapsService;

        public MapsController(IMapsService mapsService)
        {
            this.mapsService = mapsService;
        }

        [HttpGet("GetTripData")]
        public async Task<IEnumerable<TripData>> GetTripDataAsync(string Id)
        {
            try
            {
                var response = await mapsService.GetTripData(Id);

                if (response == null)
                {
                    return null;
                }

                return response;
            }
            catch
            {
                throw;
            }
        }
    }
}
