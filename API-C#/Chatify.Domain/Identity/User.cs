using Microsoft.AspNetCore.Identity;

namespace Chatify.Domain.Identity
{
    public class User : IdentityUser<int>
    {
        public string Name { get; set; }
        public virtual IEnumerable<UserRole>? UserRoles { get; set; }
    }
}