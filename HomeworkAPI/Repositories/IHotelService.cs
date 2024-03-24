using System.Threading.Tasks;
using HomeworkAPI.Entities;
namespace HomeworkAPI.Repositories
{
    public interface IHotelService
    {
        public Task<List<Hotel>> HotelSearchByRadius(decimal latitude, decimal longitude);
    }
}
