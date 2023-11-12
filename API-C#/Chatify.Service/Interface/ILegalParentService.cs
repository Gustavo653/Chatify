using Common.DTO;
using Common.Infrastructure;
using Chatify.DTO;

namespace Chatify.Service.Interface
{
    public interface ILegalParentService : IServiceBase<LegalParentDTO>
    {
        Task<ResponseDTO> GetLegalParentsForListbox();
    }
}