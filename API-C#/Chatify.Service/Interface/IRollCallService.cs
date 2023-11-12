using Common.DTO;
using Chatify.DTO;

namespace Chatify.Service.Interface
{
    public interface IRollCallService
    {
        Task<ResponseDTO> GenerateRollCall(int? teacherId = null);
        Task<ResponseDTO> GetRollCall(DateOnly? date = null, int? studentId = null, int? teacherId = null);
        Task<ResponseDTO> SetPresence(PresenceDTO presenceDTO, int? teacherId = null);
    }
}