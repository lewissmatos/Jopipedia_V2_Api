using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JopipediaAPI.Data.DTO.Rank;
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

    public class RankController : ControllerBase
    {
        
        private readonly IRankService _rankService;
        
        public RankController(IRankService rankService)
        {
            _rankService = rankService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var response = await _rankService.GetAll();
          
            return await ValidateResponse.Validate(this, response);

        }
        
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var response = await _rankService.GetById(id);
          
            return await ValidateResponse.Validate(this, response);

        }
        
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] RankDTO body)
        {
            var response = await _rankService.Create(body);
          
            return await ValidateResponse.Validate(this, response);

        }
        
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Guid id, [FromBody] RankDTO body)
        {
            var response = await _rankService.Update(id, body);
          
            return await ValidateResponse.Validate(this, response);

        }
        
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var response = await _rankService.Delete(id);
          
            return await ValidateResponse.Validate(this, response);
        }
        
        //Validate the result of the service
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
