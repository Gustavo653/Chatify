using Chatify.DataAccess.Interface;
using Common.DataAccess;
using Chatify.Domain.Identity;
using Chatify.Persistence;

namespace Chatify.DataAccess
{
    public class UserRepository : BaseRepository<User, ChatifyContext>, IUserRepository
    {
        public UserRepository(ChatifyContext context) : base(context)
        {
        }
    }
}
