using VacationSiteAPI.Data;
using VacationSiteAPI.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;


namespace VacationSiteAPI.Repositories
{
    public class EllaAPI : IEllaAPI
    {
        private readonly DbContextClass _dbContextClass;
        public EllaAPI(DbContextClass dbContextClass)
        {
            _dbContextClass = dbContextClass;
        }
        public async Task<List<Hotel>> HotelSearchByRadius(decimal latitude, decimal longitude)

        {
            var longitudeparam = new SqlParameter("@longitude", longitude);
            var latitudeparam = new SqlParameter("@latitude", latitude);
            var hotelDetails = await Task.Run(() => _dbContextClass.Hotel.FromSqlRaw("exec HotelSearchByRadius @longitude,@latitude", longitude, latitude).ToListAsync());
            return hotelDetails;
        }

        public async Task<List<RoomAvail>> RoomGetAvailabilityByDateRange(DateOnly StartDate, DateOnly EndDate)
        {
            var Startdateparam = new SqlParameter("@StartDate", StartDate);
            var Enddateparam = new SqlParameter("@EndDate", EndDate);
            var roomDetails = await Task.Run(() => _dbContextClass.RoomAvail.FromSqlRaw("exec RoomGetAvailabilityByDateRange @Startdate,@EndDate", Startdate, EndDate).ToListAsync());
            return roomDetails;
        }
    }
}
