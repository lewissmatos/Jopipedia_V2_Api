using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JopipediaAPI.Data.DTO.Quiz;
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

    public class QuizController : ControllerBase
    {
        private readonly IQuizService _quizService;
        
        public QuizController(IQuizService quizService)
        {
            _quizService = quizService;
        }
        
        [HttpGet]
        public async Task<IActionResult> GetAll([FromQuery] QuizFiltersDTO filters)
        {
            var response = await _quizService.GetAll(filters);
            
            return await ValidateResponse.Validate(this, response);
        }
        
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var response = await _quizService.GetById(id);
            
            return await ValidateResponse.Validate(this, response);
        }
        
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] QuizDTO quiz)
        {
            
            Guid userId = (Guid)AuthManager.GetCurrentUser(HttpContext).Id;
            quiz.CreatedById = userId;
            var response = await _quizService.Create(quiz);
            
            return await ValidateResponse.Validate(this, response);
        }
        
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Guid id, [FromBody] QuizDTO quiz)
        {
            var response = await _quizService.Update(id, quiz);
            
            return await ValidateResponse.Validate(this, response);
        }
        
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var response = await _quizService.Delete(id);
            
            return await ValidateResponse.Validate(this, response);
        }
        
        
        //Validate the result of the service
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
