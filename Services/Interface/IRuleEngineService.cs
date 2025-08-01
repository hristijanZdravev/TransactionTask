using TransactionTask.DTOs;
using TransactionTask.Models;

namespace TransactionTask.Services.Implementations
{
    public interface IRuleEngineService
    {
        TransactionResponseDTO Evaluate(TransactionRequestDTO tx, List<FeeRule> rules);
    }
}
