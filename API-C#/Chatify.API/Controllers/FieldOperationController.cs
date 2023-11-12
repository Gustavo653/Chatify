using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Chatify.Domain.Enum;
using Chatify.DTO;
using Chatify.Service.Interface;

namespace Chatify.API.Controllers
{
    public class FieldOperationController : BaseController
    {
        private readonly IFieldOperationService _fieldOperationService;

        public FieldOperationController(IFieldOperationService fieldOperationService)
        {
            _fieldOperationService = fieldOperationService;
        }

        [HttpPost("")]
        [Authorize(Roles = nameof(RoleName.Admin))]
        public async Task<IActionResult> CreateFieldOperation([FromBody] FieldOperationDTO fieldOperationDTO)
        {
            var fieldOperation = await _fieldOperationService.Create(fieldOperationDTO);
            return StatusCode(fieldOperation.Code, fieldOperation);
        }

        [HttpPut("{id}")]
        [Authorize(Roles = nameof(RoleName.Admin))]
        public async Task<IActionResult> UpdateFieldOperation([FromRoute] int id, [FromBody] FieldOperationDTO fieldOperationDTO)
        {
            var fieldOperation = await _fieldOperationService.Update(id, fieldOperationDTO);
            return StatusCode(fieldOperation.Code, fieldOperation);
        }

        [HttpDelete("{id}")]
        [Authorize(Roles = nameof(RoleName.Admin))]
        public async Task<IActionResult> RemoveFieldOperation([FromRoute] int id)
        {
            var fieldOperation = await _fieldOperationService.Remove(id);
            return StatusCode(fieldOperation.Code, fieldOperation);
        }

        [HttpGet("")]
        [Authorize(Roles = nameof(RoleName.Admin))]
        public async Task<IActionResult> GetFieldOperations()
        {
            var fieldOperation = await _fieldOperationService.GetList();
            return StatusCode(fieldOperation.Code, fieldOperation);
        }

        [HttpGet("Listbox")]
        [Authorize(Roles = nameof(RoleName.Admin))]
        public async Task<IActionResult> GetFieldOperationsForListbox()
        {
            var graduation = await _fieldOperationService.GetFieldOperationsForListbox();
            return StatusCode(graduation.Code, graduation);
        }
    }
}