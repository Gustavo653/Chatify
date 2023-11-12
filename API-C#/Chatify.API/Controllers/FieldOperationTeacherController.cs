using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Chatify.Domain.Enum;
using Chatify.DTO;
using Chatify.Service.Interface;

namespace Chatify.API.Controllers
{
    public class FieldOperationTeacherController : BaseController
    {
        private readonly IFieldOperationTeacherService _fieldOperationTeacherService;

        public FieldOperationTeacherController(IFieldOperationTeacherService fieldOperationTeacherService)
        {
            _fieldOperationTeacherService = fieldOperationTeacherService;
        }

        [HttpPost("")]
        [Authorize(Roles = nameof(RoleName.Admin))]
        public async Task<IActionResult> CreateFieldOperationTeacher([FromBody] FieldOperationTeacherDTO fieldOperationTeacherDTO)
        {
            var fieldOperationTeacher = await _fieldOperationTeacherService.Create(fieldOperationTeacherDTO);
            return StatusCode(fieldOperationTeacher.Code, fieldOperationTeacher);
        }

        [HttpPut("{id}")]
        [Authorize(Roles = nameof(RoleName.Admin))]
        public async Task<IActionResult> UpdateFieldOperationTeacher([FromRoute] int id, [FromBody] FieldOperationTeacherDTO fieldOperationTeacherDTO)
        {
            var fieldOperationTeacher = await _fieldOperationTeacherService.Update(id, fieldOperationTeacherDTO);
            return StatusCode(fieldOperationTeacher.Code, fieldOperationTeacher);
        }

        [HttpDelete("{id}")]
        [Authorize(Roles = nameof(RoleName.Admin))]
        public async Task<IActionResult> RemoveFieldOperationTeacher([FromRoute] int id)
        {
            var fieldOperationTeacher = await _fieldOperationTeacherService.Remove(id);
            return StatusCode(fieldOperationTeacher.Code, fieldOperationTeacher);
        }

        [HttpGet("")]
        [Authorize(Roles = nameof(RoleName.Admin))]
        public async Task<IActionResult> GetFieldOperationTeachers()
        {
            var fieldOperationTeacher = await _fieldOperationTeacherService.GetList();
            return StatusCode(fieldOperationTeacher.Code, fieldOperationTeacher);
        }

        [HttpGet("Listbox")]
        [Authorize(Roles = nameof(RoleName.Admin))]
        public async Task<IActionResult> GetFieldOperationTeachersForListbox()
        {
            var fieldOperationTeachers = await _fieldOperationTeacherService.GetFieldOperationTeachersForListbox();
            return StatusCode(fieldOperationTeachers.Code, fieldOperationTeachers);
        }
    }
}