using System.ComponentModel.DataAnnotations;

namespace Chatify.DTO
{
    public class AddressDTO
    {
        [Required]
        public required string StreetName { get; set; }
        [Required]
        public required string StreetNumber { get; set; }
        [Required]
        public required string Neighborhood { get; set; }
    }
}
