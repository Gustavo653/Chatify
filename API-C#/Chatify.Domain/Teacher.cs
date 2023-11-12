using Chatify.Domain.Identity;

namespace Chatify.Domain
{
    public class Teacher : User
    {
        public virtual Teacher? MainTeacher { get; set; }
        public virtual IEnumerable<Teacher>? AssistantTeachers { get; set; }
    }
}
