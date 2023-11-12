using Common.DTO;
using Common.Infrastructure;
using Chatify.DTO;

namespace Chatify.Service.Interface
{
    public interface IFieldOperationService : IServiceBase<FieldOperationDTO>
    {
        Task<ResponseDTO> GetFieldOperationsForListbox();
    }
}