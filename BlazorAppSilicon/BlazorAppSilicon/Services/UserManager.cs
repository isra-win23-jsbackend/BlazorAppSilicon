using BlazorAppSilicon.Data;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace BlazorAppSilicon.Services
{
    public class UserManager
    {
        private readonly ApplicationDbContext _context;

        public UserManager(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<ApplicationUser> GetUserAsync(ClaimsPrincipal principal)
        {
            var userId = principal.FindFirstValue(ClaimTypes.NameIdentifier);
            return await _context.Users.FindAsync(userId);
        }

        public async Task CreateUserAsync(ApplicationUser user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(ApplicationUser user)
        {
            _context.Users.Update(user);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteUserAsync(string userId)
        {
            var user = await _context.Users.FindAsync(userId);
            if (user != null)
            {
                _context.Users.Remove(user);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<ApplicationUser> FindByIdAsync(string userId)
        {
            return await _context.Users.FindAsync(userId);
        }
        public async Task<IEnumerable<ApplicationUser>> GetAllUsersAsync()
        {
            return await _context.Users.ToListAsync();
        }


    }

}
