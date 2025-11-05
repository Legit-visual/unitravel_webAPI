using unitravel_webAPI.Models.Requests;
using unitravel_webAPI.Models.Responses;
using unitravel_webAPI.Models.Responses.HotelDetails;

namespace unitravel_webAPI.Services.Interfaces
{
    public interface IHotelBookingDetailsBasedOnDateService
    {
        Task<HotelBookingDetailBasedOnDateResponse?> HotelBookingDetailsAsync(HotelBookingDetailBasedOnDateRequest request);
    }
}
