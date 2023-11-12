
using Chatify.Domain.Identity;

namespace Chatify.Service.Interface
{
    public interface ITokenService
    {
        Task<string> CreateToken(User userDTO);
    }
}