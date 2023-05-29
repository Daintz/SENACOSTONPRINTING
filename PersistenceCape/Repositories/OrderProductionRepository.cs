﻿using DataCape.Models;
using Microsoft.EntityFrameworkCore;
using PersistenceCape.Contexts;
using PersistenceCape.Interfaces;

namespace PersistenceCape.Repositories
{
    public class OrderProductionRepository : IOrderProductionRepository
    {
        private readonly SENAONPRINTINGContext _context;

        public OrderProductionRepository(SENAONPRINTINGContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<OrderProductionModel>> GetAllAsync()
        {
            return await _context.OrderProductions.ToListAsync();
        }

        public async Task<OrderProductionModel> GetByIdAsync(long id)
        {
            return await _context.OrderProductions.FindAsync(id);
        }

        public async Task UpdateAsync(OrderProductionModel orderProduction)
        {
            _context.Entry(orderProduction).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task<OrderProductionModel> AddAsync(OrderProductionModel orderProduction)
        {
            await _context.OrderProductions.AddAsync(orderProduction);
            await _context.SaveChangesAsync();
            return orderProduction;
        }

        public async Task ChangeState(long id)
        {
            var orderProduction = await _context.OrderProductions.FindAsync(id);
            await _context.SaveChangesAsync();
        }      

    }
}