using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JopipediaAPI.Data.DTO.Rank;
using JopipediaAPI.Data.Service.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JopipediaAPI.Controllers
{
    
    
    [Route("api/[controller]")]
    [ApiController]
    public class UserRankController : ControllerBase
    {
        
        private readonly IUserRankService _userRankService;
        
        public UserRankController(IUserRankService userRankService)
        {
            _userRankService = userRankService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var response = await _userRankService.GetAll();
          
            return await ValidateResult(response);

        }
        
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var response = await _userRankService.GetById(id);
          
            return await ValidateResult(response);

        }
        
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] UserRankDTO body)
        {
            var response = await _userRankService.Create(body);
          
            return await ValidateResult(response);

        }
        
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Guid id, [FromBody] UserRankDTO body)
        {
            var response = await _userRankService.Update(id, body);
          
            return await ValidateResult(response);

        }
        
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var response = await _userRankService.Delete(id);
          
            return await ValidateResult(response);
        }
        
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
