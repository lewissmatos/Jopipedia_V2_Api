using JopipediaAPI.Data.DTO.StopGame;
using JopipediaAPI.Data.Framework.Helpers;
using JopipediaAPI.Data.Service.Interface;
using Microsoft.AspNetCore.Mvc;
using tsprojectsAPI.Data.Framework.Helpers;

namespace JopipediaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StopGameAnswerController : ControllerBase
    {
        private readonly IStopGameAnswerService _stopGameAnswerServiceService;
        
        public StopGameAnswerController(IStopGameAnswerService stopGameAnswerServiceService)
        {
            _stopGameAnswerServiceService = stopGameAnswerServiceService;
        }
        
        [HttpGet("{roundId}")]
        async public Task<IActionResult> GetAnswers(Guid roundId)
        {
            var response = await _stopGameAnswerServiceService.GetAnswers(roundId);
            
            return await ValidateResponse.Validate(this, response);
        }
        
        [HttpPost]
        async public Task<IActionResult> Create([FromBody] CreateStopGameAnswerDTO answer)
        {

            Guid userId = (Guid)AuthManager.GetCurrentUser(HttpContext).Id;

            answer.UserId = userId;
            var response = await _stopGameAnswerServiceService.Create(answer);
            
            return await ValidateResponse.Validate(this, response);
        }
        
        
        [HttpPost("CheckResult")]
        public async Task<IActionResult> CheckResult([FromBody] StopGameCheckResultDTO result )
        {
            var response = await _stopGameAnswerServiceService.CheckResult(result);
           
            return await ValidateResponse.Validate(this, response);
        }
    }
}
