using unitravel_webAPI.Models.Requests;
using unitravel_webAPI.Models.Responses.BookingDetail;

namespace unitravel_webAPI.Services.Interfaces
{
    public interface IBookingDetailService
    {
        Task<BookingDetailReponse?> BookingDetailAsync(BookingDetailRequest? request);
    }
}
