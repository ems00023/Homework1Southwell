using System.Threading.Tasks;
using VacationSiteAPI.Entities;
namespace VacationSiteAPI.Repositories
{
    public interface IHotelService
    {
        public Task<List<Hotel>> HotelSearchByRadius(decimal latitude, decimal longitude);
    }
}
