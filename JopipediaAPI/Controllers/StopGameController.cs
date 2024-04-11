
using JopipediaAPI.Data.DTO.StopGame;
using JopipediaAPI.Data.Service.Interface;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using tsprojectsAPI.Data.Framework.Helpers;

namespace JopipediaAPI.Controllers


{
    
    
    [Route("api/[controller]")]
    [ApiController]
    public class StopGameController : ControllerBase
    {
        private readonly IStopGameService _stopGameService;
        
        public StopGameController(IStopGameService stopGameService)
        {
            _stopGameService = stopGameService;
        }
        
        [HttpPost]
        public async Task<IActionResult> Check([FromBody] StopGameCheckResultsDTO results )
        {
            var response = await _stopGameService.CheckWord(results);
           
            return await ValidateResponse.Validate(this, response);
        }
    }
}
