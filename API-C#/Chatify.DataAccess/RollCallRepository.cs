using Chatify.DataAccess.Interface;
using Common.DataAccess;
using Chatify.Domain;
using Chatify.Persistence;

namespace Chatify.DataAccess
{
    public class RollCallRepository : BaseRepository<RollCall, ChatifyContext>, IRollCallRepository
    {
        public RollCallRepository(ChatifyContext context) : base(context)
        {
        }
    }
}
