using Common.DTO;
using Chatify.DTO;

namespace Chatify.Service.Interface
{
    public interface IAccountService
    {
        Task<ResponseDTO> GetCurrent(string email);
        Task<ResponseDTO> Login(UserLoginDTO userLoginDTO);
    }
}