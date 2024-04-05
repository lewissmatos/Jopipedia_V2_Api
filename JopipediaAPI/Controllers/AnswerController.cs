using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JopipediaAPI.Data.DTO.Answer;
using JopipediaAPI.Data.Service.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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
        public async Task<IActionResult> GetAll()
        {
            var response = await _answerService.GetAll();
            return await ValidateResult(response);
        }
        
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var response = await _answerService.GetById(id);
            return await ValidateResult(response);
        }
        
        [HttpPost]
        public async Task<IActionResult> Create(AnswerDTO answer)
        {
            var response = await _answerService.Create(answer);
            return await ValidateResult(response);
        }
        
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Guid id, AnswerDTO answer)
        {
            var response = await _answerService.Update(id, answer);
            return await ValidateResult(response);
        }
        
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var response = await _answerService.Delete(id);
            return await ValidateResult(response);
        }
        
        //Validate the result of the service
        private async Task<IActionResult> ValidateResult(dynamic response)
        {
            if(response.IsNotFound)
                return NotFound(new {response.Data, response.Message});

            if(response.IsBadRequest)
                return BadRequest(new {response.Data, response.Message});

            // Implement the pagination here and also to the other controllers
            var meta = new 
            {
                currentPage = 0,
                totalPages = 0,
                pageSize = 0,
                totalCount = 0
            };
            return Ok(new { response.Data, response.Message, meta });
        }
        
    }
}
