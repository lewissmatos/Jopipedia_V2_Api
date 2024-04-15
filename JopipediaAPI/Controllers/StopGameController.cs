
using JopipediaAPI.Data.DTO.Pagination;
using JopipediaAPI.Data.DTO.StopGame;
using JopipediaAPI.Data.DTO.User;
using JopipediaAPI.Data.Framework.Helpers;
using JopipediaAPI.Data.Model;
using JopipediaAPI.Data.Service.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using tsprojectsAPI.Data.Framework.Helpers;

namespace JopipediaAPI.Controllers

{
    
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]

    public class StopGameController : ControllerBase
    {
        private readonly IStopGameService _stopGameService;
        
        public StopGameController(IStopGameService stopGameService)
        {
            _stopGameService = stopGameService;
        }
        
        [HttpGet]
        public async Task<IActionResult> GetAll([FromQuery] PaginationParamsDTO paginationParams)
        {
            var response = await _stopGameService.GetAll(paginationParams);
            
            return await ValidateResponse.Validate(this, response);
        }
        
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var response = await _stopGameService.GetById(id);
            
            return await ValidateResponse.Validate(this, response);
        }
        
        [HttpPost]
        public async Task<IActionResult> Create()
        {
            var response = await _stopGameService.Create();
            
            return await ValidateResponse.Validate(this, response);
        }
        
        [HttpPost("End/{id}")]
        public async Task<IActionResult> End(Guid id)
        {
            var response = await _stopGameService.End(id);
            
            return await ValidateResponse.Validate(this, response);
        }
        
        [HttpPut("Join/{code}")]
        public async Task<IActionResult> Join(string code)
        {
            Guid userId = (Guid)AuthManager.GetCurrentUser(HttpContext).Id;
            var response = await _stopGameService.Join( new JoinStopGameDTO(){ Code = code, UserId = userId } );
            return await ValidateResponse.Validate(this, response);
        }
        
    }
}
