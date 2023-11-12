using Chatify.DataAccess.Interface;
using Common.DataAccess;
using Chatify.Domain;
using Chatify.Persistence;

namespace Chatify.DataAccess
{
    public class StudentRepository : BaseRepository<Student, ChatifyContext>, IStudentRepository
    {
        public StudentRepository(ChatifyContext context) : base(context)
        {
        }
    }
}
