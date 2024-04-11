using JopipediaAPI.Data.DTO.User;
using JopipediaAPI.Data.Framework.Helpers;
using JopipediaAPI.Data.Service.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using tsprojectsAPI.Data.Framework.Helpers;

namespace JopipediaAPI.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]

    public class UserController : ControllerBase
    {
        
        private readonly IUserService _userService;
        
        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        
        [HttpGet]
        public async Task<IActionResult> GetAll([FromQuery] UserFiltersDTO? filters)
        {
            var response = await _userService.GetAll(filters);
          
            return await ValidateResponse.Validate(this, response);
        }
        
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var response = await _userService.GetById(id);
          
            return await ValidateResponse.Validate(this, response);
        }
        
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Guid id, [FromBody] UpdateUserPayloadDTO body)
        {
            var response = await _userService.Update(id, body);
          
            return await ValidateResponse.Validate(this, response);
        }
        
        [HttpPut("{id}/disable")]
        public async Task<IActionResult> Disable(Guid id)
        {
            var response = await _userService.Disable(id);
          
            return await ValidateResponse.Validate(this, response);
        }
        
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var response = await _userService.Delete(id);
          
            return await ValidateResponse.Validate(this, response);
        }
        
        [HttpPut("{id}/level")]
        public async Task<IActionResult> UpdateUserLevel(Guid id, [FromBody] double value)
        {
            var response = await _userService.UpdateUserLevel(id, value);
  
            return await ValidateResponse.Validate(this, response);
        }
        
        [HttpPut("{id}/rank")]
        public async Task<IActionResult> UpdateUserRank(Guid id, [FromBody] double value)
        {
            var response = await _userService.UpdateUserRank(id, value);
  
            return await ValidateResponse.Validate(this, response);
        }
    }
}

