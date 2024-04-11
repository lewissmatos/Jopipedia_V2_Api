using JopipediaAPI.Data.DTO.UserRole;
using JopipediaAPI.Data.Service.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using tsprojectsAPI.Data.Framework.Helpers;

namespace JopipediaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]

    public class UserRoleController : ControllerBase
    {
        
        private readonly IUserRoleService _userRoleService;
        
        public UserRoleController(IUserRoleService userRoleService)
        {
            _userRoleService = userRoleService;
        }
        
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
          var response = await _userRoleService.GetAll();
          
          return await ValidateResponse.Validate(this, response);

        }
        
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var response = await _userRoleService.GetById(id);
          
            return await ValidateResponse.Validate(this, response);

        }
        
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] UserRoleDTO body)
        {
            var response = await _userRoleService.Create(body);
          
            return await ValidateResponse.Validate(this, response);

        }
        
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Guid id, [FromBody] UserRoleDTO body)
        {
            var response = await _userRoleService.Update(id, body);
          
            return await ValidateResponse.Validate(this, response);

        }
        
        private async Task<IActionResult> ValidateResult(dynamic response)
        {
            if(response.IsNotFound)
                return NotFound(new {response.Data, response.Message});

            if(response.IsBadRequest)
                return BadRequest(new {response.Data, response.Message});

            return Ok(new { response.Data, response.Message });
        }
        
    }
}
