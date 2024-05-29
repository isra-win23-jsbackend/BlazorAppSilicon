using BlazorAppSilicon.Data.Entities;
using Microsoft.AspNetCore.Identity;

namespace BlazorAppSilicon.Data
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string? Biography { get; set; }
        public string? ProfilImage { get; set; } 

        public int? AddressId { get; set; } 
        public AddressEntity? Address { get; set; } 


    }

}
