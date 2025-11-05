using unitravel_webAPI.Models.Requests;
using unitravel_webAPI.Models.Responses.HotelDetails;

namespace unitravel_webAPI.Services.Interfaces
{
    public interface IHotelDetailsService
    {
        Task<HotelDetailsResponse?> HotelDetailsAsync(HotelDetailsRequest request);
    }
}
