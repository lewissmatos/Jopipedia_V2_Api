using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JopipediaAPI.Data.DTO.Pagination;
using JopipediaAPI.Data.DTO.Question;
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

    public class QuestionController : ControllerBase
    {
        private readonly IQuestionService _questionService;
        
        public QuestionController(IQuestionService questionService)
        {
            _questionService = questionService;
        }
        
        [HttpGet]
        public async Task<IActionResult> GetAll([FromQuery] QuestionFitlersDTO filters)
        {
            var response = await _questionService.GetAll(filters);
            return await ValidateResponse.Validate(this, response);
        }
        
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var response = await _questionService.GetById(id);
            return await ValidateResponse.Validate(this, response);
        }
        
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] QuestionDTO question)
        {
            var response = await _questionService.Create(question);
            return await ValidateResponse.Validate(this, response);
        }
        
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Guid id, [FromBody] QuestionDTO question)
        {
            var response = await _questionService.Update(id, question);
            return await ValidateResponse.Validate(this, response);
        }
        
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var response = await _questionService.Delete(id);
            return await ValidateResponse.Validate(this, response);
        }
        
        
        [HttpPost("save-questions-and-answers")]
        public async Task<IActionResult> SaveQuestionsAndAnswers([FromBody] List<QuestionDTO> questionsAndAnswers)
        {
            var response = await _questionService.SaveQuestionsAndAnswers(questionsAndAnswers);
            return await ValidateResponse.Validate(this, response);
        }
    }
}

