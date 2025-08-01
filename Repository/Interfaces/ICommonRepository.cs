
using TransactionTask.DTOs;

namespace TransactionTask.Repository.Interfaces
{
    public interface ICommonRepository<T, B>
        where T : class
        where B : class
    {
        Task<T?> GetByIdAsync(int id);
        Task<bool> ExistsAsync(int id);
        Task<bool> ExistAllAsync(List<int> ids);
        Task<List<B>> GetAllAsync(); // Fixed here
    }

}
