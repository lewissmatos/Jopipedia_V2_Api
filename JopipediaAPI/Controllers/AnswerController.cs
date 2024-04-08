using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JopipediaAPI.Data.DTO.Answer;
using JopipediaAPI.Data.DTO.Pagination;
using JopipediaAPI.Data.Service.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using tsprojectsAPI.Data.Framework.Helpers;

namespace JopipediaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnswerController : ControllerBase
    {
        
        private readonly IAnswerService _answerService;
        
        public AnswerController(IAnswerService answerService)
        {
            _answerService = answerService;
        }
        
        [HttpGet]
        public async Task<IActionResult> GetAll([FromQuery] AnswerFiltersDTO filters)
        {
            var response = await _answerService.GetAll(filters);
            return await ValidateResponse.Validate(this, response);
        }
        
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var response = await _answerService.GetById(id);
            return await ValidateResponse.Validate(this, response);

        }
        
        [HttpPost]
        public async Task<IActionResult> Create(AnswerDTO answer)
        {
            var response = await _answerService.Create(answer);
            return await ValidateResponse.Validate(this, response);
        }
        
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Guid id, AnswerDTO answer)
        {
            var response = await _answerService.Update(id, answer);
            return await ValidateResponse.Validate(this, response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var response = await _answerService.Delete(id);
            return await ValidateResponse.Validate(this, response);
        }

    }
}
