using BlazorAppSilicon.Data;
using Microsoft.AspNetCore.Identity;

namespace BlazorAppSilicon.Components.Account
{
    internal sealed class IdentityUserAccessor(UserManager<ApplicationUser> userManager, IdentityRedirectManager redirectManager)
    {
        private readonly UserManager<ApplicationUser> _userManager = userManager;
        private readonly IdentityRedirectManager _redirectManager = redirectManager;

        public async Task<ApplicationUser> GetRequiredUserAsync(HttpContext context)
        {
            if (context is null)
            {
               
                return null!;
            }

            var user = await _userManager.GetUserAsync(context.User);

            if (user is null)
            {
                _redirectManager.RedirectToWithStatus("Account/InvalidUser", $"Error: Unable to load user with ID '{_userManager.GetUserId(context.User)}'.", context);
            }

            return user;
        }

    }
}




//using Microsoft.AspNetCore.Identity;

//namespace BlazorAppSilicon.Components.Account
//{
//    internal sealed class IdentityUserAccessor(UserManager<ApplicationUser> userManager, IdentityRedirectManager redirectManager)
//    {
//        public async Task<ApplicationUser> GetRequiredUserAsync(HttpContext context)
//        {
//            var user = await userManager.GetUserAsync(context.User);

//            if (user is null)
//            {
//                redirectManager.RedirectToWithStatus("Account/InvalidUser", $"Error: Unable to load user with ID '{userManager.GetUserId(context.User)}'.", context);
//            }

//            return user;
//        }
//    }
//}
