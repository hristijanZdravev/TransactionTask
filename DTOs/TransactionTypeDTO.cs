using System.ComponentModel.DataAnnotations;
using TransactionTask.Models;

namespace TransactionTask.DTOs
{
    public class TransactionTypeDTO
    {
        [Required(ErrorMessage = "Id of TransactionType is required.")]
        public required int Id { get; set; }

        [Required(ErrorMessage = "Name of TransactionType is required.")]
        public required string Name { get; set; }

        public static TransactionTypeDTO toDTO(TransactionType t)
        {
            return new TransactionTypeDTO
            {
                Id = t.Id,
                Name = t.Name
            };
        }
    }
}