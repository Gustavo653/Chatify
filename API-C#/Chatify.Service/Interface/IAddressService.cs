using Common.DTO;
using Common.Infrastructure;
using Chatify.DTO;

namespace Chatify.Service.Interface
{
    public interface IAddressService : IServiceBase<AddressDTO>
    {
        Task<ResponseDTO> GetAddressesForListbox();
    }
}