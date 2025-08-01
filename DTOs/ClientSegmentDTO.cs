﻿using System.ComponentModel.DataAnnotations;
using TransactionTask.Models;

namespace TransactionTask.DTOs
{
    public class ClientSegmentDTO
    {
        [Required(ErrorMessage = "Id of ClientSegment is required.")]
        public required int Id { get; set; }

        [Required(ErrorMessage = "Name of ClientSegment is required.")]
        public required string Name { get; set; }

        internal static ClientSegmentDTO toDTO(ClientSegment clientSegment)
        {
            return new ClientSegmentDTO
            {
                Id = clientSegment.Id,
                Name = clientSegment.Name
            };
        }
    }
}