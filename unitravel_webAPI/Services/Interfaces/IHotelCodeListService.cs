using unitravel_webAPI.Models.Responses;

namespace unitravel_webAPI.Services.Interfaces
{
    public interface IHotelCodeListService
    {
        Task<HotelCodeListResponse?> HotelCodeListAsync();
    }
}
