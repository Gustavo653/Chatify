using Chatify.DataAccess.Interface;
using Common.DataAccess;
using Chatify.Domain;
using Chatify.Persistence;

namespace Chatify.DataAccess
{
    public class FieldOperationRepository : BaseRepository<FieldOperation, ChatifyContext>, IFieldOperationRepository
    {
        public FieldOperationRepository(ChatifyContext context) : base(context)
        {
        }
    }
}
