using Common.DTO;
using Common.Infrastructure;
using Chatify.DTO;

namespace Chatify.Service.Interface
{
    public interface IGraduationService : IServiceBase<GraduationDTO>
    {
        Task<ResponseDTO> GetGraduationsForListbox();
    }
}