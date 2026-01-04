using Microsoft.EntityFrameworkCore;
using MyBlazorApp.Data;
using MyBlazorApp.Models;

namespace MyBlazorApp.Services
{
    public class BookService
    {
        private readonly AppDbContext _db;
        
        public BookService(AppDbContext db) => _db = db;

        public async Task<List<Book>> GetAllAsync() => await _db.Books.ToListAsync();
        
        public async Task<Book?> GetByIdAsync(int id) => await _db.Books.FindAsync(id);
        
        public async Task AddAsync(Book b) 
        { 
            _db.Books.Add(b); 
            await _db.SaveChangesAsync(); 
        }
        
        public async Task UpdateAsync(Book b) 
        { 
            _db.Books.Update(b); 
            await _db.SaveChangesAsync(); 
        }
        
        public async Task DeleteAsync(int id) 
        { 
            var b = await _db.Books.FindAsync(id); 
            if (b != null) 
            { 
                _db.Books.Remove(b); 
                await _db.SaveChangesAsync(); 
            } 
        }
    }
}