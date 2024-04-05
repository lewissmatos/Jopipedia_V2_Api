using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JopipediaAPI.Data.DTO.Topic;
using JopipediaAPI.Data.Service.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JopipediaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TopicController : ControllerBase
    {
        private readonly ITopicService _topicService;
        
        public TopicController(ITopicService topicService)
        {
            _topicService = topicService;
        }
        
        [HttpGet]
        async public Task<IActionResult> GetAll()
        {
            var response = await _topicService.GetAll();
            return await ValidateResult(response);
        }
        
        [HttpGet("{id}")]
        async public Task<IActionResult> GetById(Guid id)
        {
            var response = await _topicService.GetById(id);
            return await ValidateResult(response);
        }
        
        [HttpPost]
        async public Task<IActionResult> Create([FromBody] TopicDTO topic)
        {
            var response = await _topicService.Create(topic);
            return await ValidateResult(response);
        }
        
        [HttpPut("{id}")]
        async public Task<IActionResult> Update(Guid id, [FromBody] TopicDTO topic)
        {
            var response = await _topicService.Update(id, topic);
            return await ValidateResult(response);
        }
        
        [HttpDelete("{id}")]
        async public Task<IActionResult> Delete(Guid id)
        {
            var response = await _topicService.Delete(id);
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
