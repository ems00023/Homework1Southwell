using VacationSiteAPI.Data;
using VacationSiteAPI.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;


namespace VacationSiteAPI.Repositories
{
    public class HotelService : IHotelService
    {
        private readonly DbContextClass _dbContextClass;
        public HotelService(DbContextClass dbContextClass)
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
    }
}
