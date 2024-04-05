using JopipediaAPI.Data.DTO.User;
using JopipediaAPI.Data.Service.Interface;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
namespace JopipediaAPI.Controllers
{
    
    
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        
        private readonly IUserService _userService;
        
        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        
        [HttpGet]
        public async Task<IActionResult> GetAllUsers()
        {
            var response = await _userService.GetAllUsers();
            
            // return await ValidateResult(response);

            if(response.IsNotFound)
                return NotFound(new {response.Data, response.Message});
          
            if(response.IsBadRequest)
                return BadRequest(new {response.Data, response.Message});
          
            return Ok(new { response.Data, response.Message });
        }
        
        [HttpGet("{id}")]
        public async Task<IActionResult> GetUserById(Guid id)
        {
            var response = await _userService.GetUserById(id);
          
            return await ValidateResult(response);

        }
        
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateUser(Guid id, [FromBody] UpdateUserPayloadDTO body)
        {
            var response = await _userService.UpdateUser(id, body);
          
            return await ValidateResult(response);

        }
        
        [HttpPut("{id}/disable")]
        public async Task<IActionResult> DisableUser(Guid id)
        {
            var response = await _userService.DisableUser(id);
          
            return await ValidateResult(response);
        }
        
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(Guid id)
        {
            var response = await _userService.DeleteUser(id);
          
            return await ValidateResult(response);
        }
        
        [HttpPut("{id}/level")]
        public async Task<IActionResult> UpdateUserLevel(Guid id, [FromBody] double value)
        {
            var response = await _userService.UpdateUserLevel(id, value);
  
            return await ValidateResult(response);
        }
        
        [HttpPut("{id}/rank")]
        public async Task<IActionResult> UpdateUserRank(Guid id, [FromBody] double value)
        {
            var response = await _userService.UpdateUserRank(id, value);
  
            return await ValidateResult(response);
        }
        
        // Helper method to validate the response
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

