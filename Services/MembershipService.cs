using Microsoft.EntityFrameworkCore;
using MyBlazorApp.Data;
using MyBlazorApp.Models;

namespace MyBlazorApp.Services
{
    public class MembershipService
    {
        private readonly AppDbContext _db;
        
        public MembershipService(AppDbContext db) => _db = db;

        public async Task<List<Membership>> GetAllAsync() => await _db.Memberships.ToListAsync();
        
        public async Task<Membership?> GetByIdAsync(int id) => await _db.Memberships.FindAsync(id);
        
        public async Task AddAsync(Membership m) 
        { 
            _db.Memberships.Add(m); 
            await _db.SaveChangesAsync(); 
        }
        
        public async Task UpdateAsync(Membership m) 
        { 
            _db.Memberships.Update(m); 
            await _db.SaveChangesAsync(); 
        }
        
        public async Task DeleteAsync(int id) 
        { 
            var m = await _db.Memberships.FindAsync(id); 
            if (m != null) 
            { 
                _db.Memberships.Remove(m); 
                await _db.SaveChangesAsync(); 
            } 
        }
    }
}