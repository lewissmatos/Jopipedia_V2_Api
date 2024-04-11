using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JopipediaAPI.Data.DTO.Award;
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

    public class AwardController : ControllerBase
    {
        private readonly IAwardService _awardService;
        
        public AwardController(IAwardService awardService)
        {
            _awardService = awardService;
        }
        
        [HttpGet]
        public async Task<IActionResult> GetAll([FromQuery] AwardFiltersDTO filters)
        {
            var response = await _awardService.GetAll(filters);
            return await ValidateResponse.Validate(this, response );
        }
        
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var response = await _awardService.GetById(id);
            return await ValidateResponse.Validate(this, response);
        }
        
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] AwardDTO award)
        {
            var response = await _awardService.Create(award);
            return await ValidateResponse.Validate(this, response);
        }
        
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Guid id, [FromBody] AwardDTO award)
        {
            var response = await _awardService.Update(id, award);
            return await ValidateResponse.Validate(this, response);
        }
        
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var response = await _awardService.Delete(id);
            return await ValidateResponse.Validate(this, response);
        }
        
    }
}
