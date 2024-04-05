using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JopipediaAPI.Data.DTO;
using JopipediaAPI.Data.Service.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JopipediaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ScoreController : ControllerBase
    {
        private readonly IScoreService _scoreService;
        
        public ScoreController(IScoreService scoreService)
        {
            _scoreService = scoreService;
        }
        
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var response = await _scoreService.GetAll();
            return await ValidateResult(response);
        }
        
        [HttpGet("{id}")]
           
        public async Task<IActionResult> GetById(Guid id)
        {
            var response = await _scoreService.GetById(id);
            return await ValidateResult(response);
        }
        
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] ScoreDTO score)
        {
            var response = await _scoreService.Create(score);
            return await ValidateResult(response);
        }
        
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Guid id, [FromBody] ScoreDTO score)
        {
            var response = await _scoreService.Update(id, score);
            return await ValidateResult(response);
        }
        
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var response = await _scoreService.Delete(id);
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
