using AutoMapper;
using Chatify.Domain;
using Chatify.Domain.Identity;
using Chatify.DTO;

namespace Chatify.Service
{
    public class ChatifyProfile : Profile
    {
        public ChatifyProfile()
        {
            CreateMap<User, UserLoginDTO>(MemberList.None).ReverseMap();
        }
    }
}