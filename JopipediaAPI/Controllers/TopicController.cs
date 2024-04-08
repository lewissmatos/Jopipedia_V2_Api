using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JopipediaAPI.Data.DTO.Pagination;
using JopipediaAPI.Data.DTO.Topic;
using JopipediaAPI.Data.Service.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using tsprojectsAPI.Data.Framework.Helpers;

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
        async public Task<IActionResult> GetAll([FromQuery] PaginationParamsDTO pagination)
        {
            var response = await _topicService.GetAll(pagination);
            return await ValidateResponse.Validate(this, response);
        }
        
        [HttpGet("{id}")]
        async public Task<IActionResult> GetById(Guid id)
        {
            var response = await _topicService.GetById(id);
            return await ValidateResponse.Validate(this, response);
        }
        
        [HttpPost]
        async public Task<IActionResult> Create([FromBody] TopicDTO topic)
        {
            var response = await _topicService.Create(topic);
            return await ValidateResponse.Validate(this, response);
        }
        
        [HttpPut("{id}")]
        async public Task<IActionResult> Update(Guid id, [FromBody] TopicDTO topic)
        {
            var response = await _topicService.Update(id, topic);
            return await ValidateResponse.Validate(this, response);
        }
        
        [HttpDelete("{id}")]
        async public Task<IActionResult> Delete(Guid id)
        {
            var response = await _topicService.Delete(id);
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
