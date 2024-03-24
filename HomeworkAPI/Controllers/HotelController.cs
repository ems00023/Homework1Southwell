﻿using Microsoft.AspNetCore.Mvc;
using HomeworkAPI.Repositories;
using HomeworkAPI.Entities;

namespace HomeworkAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelController : Controller
    {

        private readonly IHotelService hotelservice;
        public HotelController(IHotelService hotelservice)
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
    }
}