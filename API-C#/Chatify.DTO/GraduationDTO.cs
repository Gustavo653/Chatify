using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using Chatify.Domain.Enum;

namespace Chatify.DTO
{
    public class GraduationDTO
    {
        [Required]
        public required string Name { get; set; }
        public IFormFile? File { get; set; }
        [Required]
        public required int Position { get; set; }
        [Required]
        public required GraduationType GraduationType { get; set; }
    }
}
