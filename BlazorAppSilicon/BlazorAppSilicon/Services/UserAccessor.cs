using BlazorAppSilicon.Data;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;

namespace BlazorAppSilicon.Services;

public interface IUserAccessor
{
    Task<ApplicationUser?> GetRequiredUserAsync(HttpContext httpContext);
}


public class UserAccessor(UserManager<ApplicationUser> userManager) : IUserAccessor
{

    private readonly UserManager<ApplicationUser> _userManager = userManager;


    public async Task<ApplicationUser?> GetRequiredUserAsync(HttpContext httpContext)
    {
        var userId = httpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
        if (userId == null)
        {
            return null;
        }
        return await _userManager.FindByIdAsync(userId);
    }


}
