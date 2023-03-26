using MagicVilla_Web.Models.DTO;

namespace MagicVilla_Web.Services.Iservices
{
    public interface IVillaService
    {
        Task<T> GetAllAsync<T>(string token);
        Task<T> GetAsync<T>(int id, string token);
        Task<T> CreateAsync<T>(VillasCreateDTO dto, string token);
        Task<T> UpdateAsync<T>(VillasUpdateDTO dto, string token);
        Task<T> DeleteAsync<T>(int id, string token);
    }
}