using MagicVilla_Web.Models.DTO;

namespace MagicVilla_Web.Services.Iservices
{
    public interface IAuthService
    {
        Task<T> LoginAsync<T>(LoginRequestDTO objToCreate);
        Task<T> RegisterAsync<T>(RegisterationRequestDTO objToCreate);
    }
}
