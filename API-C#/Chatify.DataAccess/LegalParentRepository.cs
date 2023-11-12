using Chatify.DataAccess.Interface;
using Common.DataAccess;
using Chatify.Domain;
using Chatify.Persistence;

namespace Chatify.DataAccess
{
    public class LegalParentRepository : BaseRepository<LegalParent, ChatifyContext>, ILegalParentRepository
    {
        public LegalParentRepository(ChatifyContext context) : base(context)
        {
        }
    }
}
