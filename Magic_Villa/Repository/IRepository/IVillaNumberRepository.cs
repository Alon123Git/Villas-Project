using Magic_Villa.Models;
using System.Linq.Expressions;

namespace Magic_Villa.Repository.IRepository
{
    public interface IVillaNumberRepository : IRepository<VillaNumber>
    {
        Task<VillaNumber> UpdateAsync(VillaNumber entity);
    }
}