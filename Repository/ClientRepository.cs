﻿using Microsoft.EntityFrameworkCore;
using TransactionTask.Data;
using TransactionTask.DTOs;
using TransactionTask.Models;
using TransactionTask.Repository.Interfaces;

namespace TransactionTask.Repository
{
    public class ClientRepository : ICommonRepository<Client, ClientDTO>
    {
        private readonly Context _context;

        public ClientRepository(Context context)
        {
            _context = context;
        }
        public async Task<bool> ExistsAsync(int id)
        {
            return await _context.Clients.AnyAsync(c => c.Id == id);
        }
        public async Task<Client?> GetByIdAsync(int id)
        {
            return await _context.Clients.FindAsync(id);
        }

        public async Task<List<ClientDTO>> GetAllAsync()
        {
            List<Client> clients = await _context.Clients.Include(c => c.ClientSegment).ToListAsync();

            return clients.Select(c => ClientDTO.toDTO(c)).ToList();
        }
        public async Task<bool> ExistAllAsync(List<int> ids)
        {
            var count = await _context.Clients.CountAsync(c => ids.Contains(c.Id));
            return count == ids.Count;
        }

    }
}
