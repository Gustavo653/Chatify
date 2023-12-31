using System.ComponentModel.DataAnnotations;
using Chatify.Domain.Enum;

namespace Chatify.DTO
{
    public class UserDTO
    {
        public required string UserName { get; set; }
        [Required]
        [EmailAddress]
        public required string Email { get; set; }
        public string? Password { get; set; }
        [Required]
        public required string Name { get; set; }
        [Required]
        public required List<RoleName> Roles { get; set; }
    }
}