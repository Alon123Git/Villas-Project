using Magic_Villa.Models;
using System.Linq.Expressions;

namespace Magic_Villa.Repository.IRepository
{
    public interface IVillaRepository : IRepository<Villa>
    {
        Task<Villa> UpdateAsync(Villa entity);
    }
}