
using JopipediaAPI.Data.DTO;
using JopipediaAPI.Data.Service.Interface;
using Microsoft.AspNetCore.Mvc;

namespace JopipediaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("Login")]
        public async Task<IActionResult> Login([FromBody] LoginPayloadDTO body)
        {
            var response = await _authService.Login(body);

            if (response.IsBadRequest)
                return BadRequest(new { response.Data, response.Message });

            if (response.IsNotFound)
                return NotFound(new { response.Data, response.Message });

            return Ok(new { response.Data, response.Message });
        }
        
        [HttpPost("SignUp")]
        public async Task<IActionResult> SignUp([FromBody] SignUpPayloadDTO body)
        {
            var response = await _authService.SignUp(body);

            if (response.IsBadRequest)
                return BadRequest(new { response.Data, response.Message });

            if (response.IsNotFound)
                return NotFound(new { response.Data, response.Message });

            return Ok(new { response.Data, response.Message });
            return Ok(response);
        }

    }

}
