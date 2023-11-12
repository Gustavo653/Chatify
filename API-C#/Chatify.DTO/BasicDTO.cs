using System.ComponentModel.DataAnnotations;

namespace Chatify.DTO
{
    public class BasicDTO
    {
        [Required]
        public required string Name { get; set; }
    }
}