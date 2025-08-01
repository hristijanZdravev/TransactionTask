using Microsoft.EntityFrameworkCore;
using TransactionTask.Data;
using TransactionTask.Models;
using TransactionTask.Repository.Interfaces;

namespace TransactionTask.Repository
{
    public class FeeRuleRepository : IFeeRuleRepository
    {
        private readonly Context _context;
        public FeeRuleRepository(Context context)
        {
            _context = context;
        }
        public async Task<List<FeeRule>> GetAllAsync()
        {
            return await _context.FeeRules.ToListAsync();
        }
        public async Task<FeeRule?> GetByIdAsync(int id)
        {
            return await _context.FeeRules.FindAsync(id);
        }
        public async Task AddAsync(FeeRule feeRule)
        {
            await _context.FeeRules.AddAsync(feeRule);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateAsync(FeeRule feeRule)
        {
            _context.FeeRules.Update(feeRule);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteAsync(int id)
        {
            var feeRule = await GetByIdAsync(id);
            if (feeRule != null)
            {
                _context.FeeRules.Remove(feeRule);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<List<FeeRule>> GetByIdsAsync(List<int> ids)
        {
            return await _context.FeeRules
                .Where(rule => ids.Contains(rule.Id))
                .ToListAsync();
        }
    }

}
