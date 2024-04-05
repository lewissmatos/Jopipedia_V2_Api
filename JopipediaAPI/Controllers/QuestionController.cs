using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JopipediaAPI.Data.DTO.Question;
using JopipediaAPI.Data.Service.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JopipediaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionController : ControllerBase
    {
        private readonly IQuestionService   _questionService;
        
        public QuestionController(IQuestionService questionService)
        {
            _questionService = questionService;
        }
        
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var questions = await _questionService.GetAll();
            return await ValidateResult(questions);
        }
        
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var question = await _questionService.GetById(id);
            return await ValidateResult(question);
        }
        
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] QuestionDTO question)
        {
            var newQuestion = await _questionService.Create(question);
            return await ValidateResult(newQuestion);
        }
        
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Guid id, [FromBody] QuestionDTO question)
        {
            var updatedQuestion = await _questionService.Update(id, question);
            return await ValidateResult(updatedQuestion);
        }
        
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var deletedQuestion = await _questionService.Delete(id);
            return await ValidateResult(deletedQuestion);
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
