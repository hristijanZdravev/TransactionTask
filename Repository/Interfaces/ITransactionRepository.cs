using TransactionTask.Models;

namespace TransactionTask.Repository.Interfaces
{
    public interface ITransactionRepository
    {
        Task AddAsync(Transaction transaction);

    }
}
