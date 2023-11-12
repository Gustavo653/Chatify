using Common.DTO;
using Common.Infrastructure;
using Chatify.DTO;

namespace Chatify.Service.Interface
{
    public interface ITeacherService : IServiceBase<TeacherDTO>
    {
        Task<ResponseDTO> GetTeacherForListbox();
    }
}