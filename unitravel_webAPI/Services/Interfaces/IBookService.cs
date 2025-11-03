using unitravel_webAPI.Models.Requests;
using unitravel_webAPI.Models.Responses;

namespace unitravel_webAPI.Services.Interfaces
{
    public interface IBookService
    {
        Task<BookResult?> BookAsync(BookRequest request);
    }
}
