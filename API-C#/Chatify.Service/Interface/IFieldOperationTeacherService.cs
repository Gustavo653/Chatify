using Common.DTO;
using Common.Infrastructure;
using Chatify.DTO;

namespace Chatify.Service.Interface
{
    public interface IFieldOperationTeacherService : IServiceBase<FieldOperationTeacherDTO>
    {
        Task<ResponseDTO> GetFieldOperationTeachersForListbox();
    }
}