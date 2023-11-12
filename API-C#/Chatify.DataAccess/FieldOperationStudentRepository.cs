using Chatify.DataAccess.Interface;
using Common.DataAccess;
using Chatify.Domain;
using Chatify.Persistence;

namespace Chatify.DataAccess
{
    public class FieldOperationStudentRepository : BaseRepository<FieldOperationStudent, ChatifyContext>, IFieldOperationStudentRepository
    {
        public FieldOperationStudentRepository(ChatifyContext context) : base(context)
        {
        }
    }
}
