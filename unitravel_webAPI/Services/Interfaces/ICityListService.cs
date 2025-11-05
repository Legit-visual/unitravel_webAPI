using unitravel_webAPI.Models.Requests;
using unitravel_webAPI.Models.Responses;

namespace unitravel_webAPI.Services.Interfaces
{
    public interface ICityListService
    {
        Task<CityListResponse?> CityListAsync(CityListRequest request);
    }
}
