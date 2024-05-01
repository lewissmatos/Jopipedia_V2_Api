using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JopipediaAPI.Data.DTO.StopGame;
using JopipediaAPI.Data.Service.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using tsprojectsAPI.Data.Framework.Helpers;

namespace JopipediaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StopGameRoundController : ControllerBase
    {
        private readonly IStopGameRoundService _stopGameRoundService;
        
        public StopGameRoundController(IStopGameRoundService stopGameRoundService)
        {
            _stopGameRoundService = stopGameRoundService;
        }
        
        [HttpGet]
        public async Task<IActionResult> GetRounds([FromQuery] StopGameRoundFiltersDTO filters)
        {
            var response = await _stopGameRoundService.GetRounds(filters);
            
            return await ValidateResponse.Validate(this, response);
        }
        
        [HttpPost]
        public async Task<IActionResult> AddRound([FromBody] AddStopGameRountDTO addStopGameRoundDto)
        {
            var response = await _stopGameRoundService.AddRound(addStopGameRoundDto);
            
            return await ValidateResponse.Validate(this, response);
        }
        
        [HttpGet("{id}")]
        public async Task<IActionResult> GetRound(Guid id)
        {
            var response = await _stopGameRoundService.GetRound(id);
            
            return await ValidateResponse.Validate(this, response);
        }
        
    }
}
