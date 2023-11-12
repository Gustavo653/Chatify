using Microsoft.AspNetCore.Identity;

namespace Chatify.Domain.Identity
{
    public class Role : IdentityRole<int>
    {
        public List<UserRole> UserRoles { get; set; }
    }
}