using Chatify.DataAccess.Interface;
using Common.DataAccess;
using Chatify.Domain;
using Chatify.Persistence;

namespace Chatify.DataAccess
{
    public class FieldOperationTeacherRepository : BaseRepository<FieldOperationTeacher, ChatifyContext>, IFieldOperationTeacherRepository
    {
        public FieldOperationTeacherRepository(ChatifyContext context) : base(context)
        {
        }
    }
}
