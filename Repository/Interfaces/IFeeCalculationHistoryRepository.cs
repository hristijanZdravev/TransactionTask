using TransactionTask.DTOs;
using TransactionTask.Models;

namespace TransactionTask.Repository.Interfaces
{
    public interface IFeeCalculationHistoryRepository
    {
        Task AddAsync(FeeCalculationHistory history);
        Task AddRangeAsync(List<FeeCalculationHistory> histories);
        Task<List<FeeCalculationHistoryDTO>> GetAllAsync();
    }
}
