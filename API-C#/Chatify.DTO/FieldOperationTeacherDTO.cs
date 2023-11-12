using System.ComponentModel.DataAnnotations;

namespace Chatify.DTO
{
    public class FieldOperationTeacherDTO
    {
        [Required]
        public required int TeacherId { get; set; }
        [Required]
        public required int FieldOperationId { get; set; }
        [Required]
        public required bool Enabled { get; set; }
    }
}
