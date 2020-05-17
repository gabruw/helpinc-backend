using Microsoft.AspNetCore.Identity;

namespace Domain.IdentityEntity
{
    public class Login : IdentityUser
    {
        public string Password { get; set; }
    }
}