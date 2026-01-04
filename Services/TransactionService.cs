using Microsoft.EntityFrameworkCore;
using MyBlazorApp.Data;
using MyBlazorApp.Models;

namespace MyBlazorApp.Services
{
    public class TransactionService
    {
        private readonly AppDbContext _db;
        
        public TransactionService(AppDbContext db) => _db = db;

        public async Task<List<Transaction>> GetAllAsync() => await _db.Transactions.ToListAsync();
        
        public async Task<Transaction?> GetByIdAsync(int id) => await _db.Transactions.FindAsync(id);
        
        public async Task AddAsync(Transaction t) 
        { 
            _db.Transactions.Add(t); 
            await _db.SaveChangesAsync(); 
        }
        
        public async Task UpdateAsync(Transaction t) 
        { 
            _db.Transactions.Update(t); 
            await _db.SaveChangesAsync(); 
        }
        
        public async Task DeleteAsync(int id) 
        { 
            var t = await _db.Transactions.FindAsync(id); 
            if (t != null) 
            { 
                _db.Transactions.Remove(t); 
                await _db.SaveChangesAsync(); 
            } 
        }
    }
}