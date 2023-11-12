using System.ComponentModel.DataAnnotations;

namespace Chatify.DTO
{
    public class UserLoginDTO
    {
        [Required]
        [EmailAddress]
        public required string Email { get; set; }
        [Required]
        public required string Password { get; set; }
    }
}