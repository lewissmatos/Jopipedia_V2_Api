using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JopipediaAPI.Data.DTO;
using JopipediaAPI.Data.DTO.Pagination;
using JopipediaAPI.Data.DTO.User;
using JopipediaAPI.Data.Framework.Helpers;
using JopipediaAPI.Data.Model;
using JopipediaAPI.Data.Service.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using tsprojectsAPI.Data.Framework.Helpers;

namespace JopipediaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]

    public class ScoreController : ControllerBase
    {
        private readonly IScoreService _scoreService;
        
        public ScoreController(IScoreService scoreService)
        {
            _scoreService = scoreService;
        }
        
        [HttpGet]
        public async Task<IActionResult> GetAll([FromQuery] PaginationParamsDTO pagination)
        {
            var response = await _scoreService.GetAll(pagination);
            return await ValidateResponse.Validate(this, response);
        }
        
        [HttpGet("{id}")]
           
        public async Task<IActionResult> GetById(Guid id)
        {
            var response = await _scoreService.GetById(id);
            return await ValidateResponse.Validate(this, response);
        }
        
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] ScoreDTO score)
        {
            UserDTO user = (UserDTO)AuthManager.GetCurrentUser(HttpContext);

            score.User = user;
            var response = await _scoreService.Create(score);
            return await ValidateResponse.Validate(this, response);
        }
        
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Guid id, [FromBody] ScoreDTO score)
        {
            var response = await _scoreService.Update(id, score);
            return await ValidateResponse.Validate(this, response);
        }
        
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var response = await _scoreService.Delete(id);
            return await ValidateResponse.Validate(this, response);
        }
        
        // Helper method to validate the response
        private async Task<IActionResult> ValidateResult(dynamic response)
        {
            if(response.IsNotFound)
                return NotFound(new {response.Data, response.Message});

            if(response.IsBadRequest)
                return BadRequest(new {response.Data, response.Message});

            return Ok(new { response.Data, response.Message, response.Meta });
        }
    }
}
