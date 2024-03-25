using Microsoft.AspNetCore.Mvc;
using VacationSiteAPI.Repositories;
using VacationSiteAPI.Entities;

namespace VacationSiteAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelController : Controller
    {

        private readonly IEllaAPI hotelservice;
        public HotelController(IEllaAPI hotelservice)
        { this.hotelservice = hotelservice; }

        [HttpGet("HotelSearchByRadius/longitude={longitude}&latitude={latitude}")]
        public async Task<List<Hotel>> HotelSearchByRadius(decimal latitude, decimal longitude)
        { 
        var hotelDetails = await hotelservice.HotelSearchByRadius(latitude, longitude);
            if (hotelDetails == null)
               {
            }
        return hotelDetails;
        
        }
        [HttpGet("RoomGetAvailabilityByDateRange/StartDate={StartDate}&EndDate={EndDate}")]
        public async Task<List<RoomAvail>> RoomGetAvailabilityByDateRange(DateOnly StartDate, DateOnly EndDate)
        {
            var RoomAvail = await hotelservice.RoomGetAvailabilityByDateRange(StartDate, EndDate);
            if (RoomAvail == null)
            { }
            return RoomAvail;
        }
    }
}
