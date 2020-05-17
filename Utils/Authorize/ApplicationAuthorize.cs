using Microsoft.AspNetCore.Http;
using System.Linq;

namespace Utils.Authorize
{
    public class ApplicationAuthorize
    {
        public static bool ValidateUserClaims(HttpContext context, string claimName, string claimValue)
        {
            return context.User.Identity.IsAuthenticated && context.User.Claims.Any(c => c.Type == claimName && c.Value.Contains(claimValue));
        }
    }
}
