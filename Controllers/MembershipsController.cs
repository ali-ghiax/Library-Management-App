using Microsoft.AspNetCore.Mvc;
using MyBlazorApp.Data;
using MyBlazorApp.Models;
using Microsoft.EntityFrameworkCore;

namespace MyBlazorApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MembershipsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public MembershipsController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Membership>>> GetMemberships()
        {
            return await _context.Memberships.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Membership>> GetMembership(int id)
        {
            var membership = await _context.Memberships.FindAsync(id);
            if (membership == null)
                return NotFound();
            return membership;
        }

        [HttpPost]
        public async Task<ActionResult<Membership>> PostMembership(Membership membership)
        {
            _context.Memberships.Add(membership);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetMembership), new { id = membership.Id }, membership);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutMembership(int id, Membership membership)
        {
            if (id != membership.Id)
                return BadRequest();

            _context.Entry(membership).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMembership(int id)
        {
            var membership = await _context.Memberships.FindAsync(id);
            if (membership == null)
                return NotFound();

            _context.Memberships.Remove(membership);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}