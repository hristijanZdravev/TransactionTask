using TransactionTask.Data;
using TransactionTask.Models;
using TransactionTask.Repository.Interfaces;

namespace TransactionTask.Repository
{
    public class TransactionRepository : ITransactionRepository
    {
        private readonly Context _context;
        public TransactionRepository(Context context)
        {
            _context = context;
        }
        public async Task AddAsync(Transaction transaction)
        {
            try
            {
                _context.Transactions.Add(transaction);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Error saving fee calculation history", ex);
            }
        }
    }
}
