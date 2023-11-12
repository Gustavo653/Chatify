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
            CreateMap<LegalParent, LegalParentDTO>(MemberList.None).ReverseMap();
            CreateMap<Student, StudentDTO>(MemberList.None).ReverseMap();
            CreateMap<Address, AddressDTO>(MemberList.None).ReverseMap();
            CreateMap<Graduation, GraduationDTO>(MemberList.None).ReverseMap();
            CreateMap<Teacher, TeacherDTO>(MemberList.None).ReverseMap();
            CreateMap<FieldOperation, FieldOperationDTO>(MemberList.None).ReverseMap();
            CreateMap<FieldOperationTeacher, FieldOperationTeacherDTO>(MemberList.None).ReverseMap();
            CreateMap<FieldOperationStudent, FieldOperationStudentDTO>(MemberList.None).ReverseMap();
        }
    }
}