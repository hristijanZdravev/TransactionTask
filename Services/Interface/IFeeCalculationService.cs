using TransactionTask.DTOs;
using TransactionTask.Models;

namespace TransactionTask.Services.Implementations
{
    public interface IFeeCalculationService
    {
        Task<TransactionResponseDTO> CalculateFeeAsync(TransactionRequestDTO request);
        Task<List<TransactionResponseDTO>> CalculateFeesBatchAsync(List<TransactionRequestDTO> requests);
        Task<List<FeeCalculationHistoryDTO>> GetCalculationHistoryAsync();
        Task<bool> ValidateTransactionRequestAsync(TransactionRequestDTO request);
        Task<bool> ValidateTransactionRequestsAsync(List<TransactionRequestDTO> requests);
    }
}
