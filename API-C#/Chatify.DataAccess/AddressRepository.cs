using Chatify.DataAccess.Interface;
using Common.DataAccess;
using Chatify.Domain;
using Chatify.Persistence;

namespace Chatify.DataAccess
{
    public class AddressRepository : BaseRepository<Address, ChatifyContext>, IAddressRepository
    {
        public AddressRepository(ChatifyContext context) : base(context)
        {
        }
    }
}
