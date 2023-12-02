using Microsoft.AspNetCore.Identity;

namespace JwtInDotNetCore.Entities
{
    public class LoginRequest
    {
        public string Name { get; set; }
        public string Password { get; set; }

    }
}
