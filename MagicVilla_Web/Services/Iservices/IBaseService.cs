using MagicVilla_Web.Models;

namespace MagicVilla_Web.Services.Iservices
{
    public interface IBaseService
    {
        APIResponse responseModel { get; set; }
        Task<T> SendAsync<T>(ApiRequest apiRequest);
    }
}
