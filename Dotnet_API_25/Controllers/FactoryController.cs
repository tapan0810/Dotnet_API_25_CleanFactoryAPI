using Dotnet_API_25.Entities.DTOs;
using Dotnet_API_25.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Dotnet_API_25.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FactoryController (IFactoryService _service): ControllerBase
    {
        [HttpGet("GetAllFactories")]
        public async Task<ActionResult<List<GetAllFactoriesDto>>> GetAllFactories(int pageNumber, int pageSize)
        {
            var result = await _service.GetAllFactoriesAsync(pageNumber, pageSize);

            if(result is null || result.Count == 0)
            {
                return NotFound("No Factories Found");
            }
            return Ok(new 
            {
                Message = "Fetched All Factories",
                Data = result
            });
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<GetFactoryByIdDto>> GetFactoryById(int id)
        {
            var factory = await _service.GetFactoryById(id);
            if (factory is null) return NotFound("Factory with this Id not exist.");
            return Ok(factory);
        }

        [HttpPost("CreateFactory")]
        public async Task<ActionResult<GetFactoryByIdDto?>> CreateFactory(CreateFactoryDto dto)
        {
            var result = await _service.CreateFactory(dto);

            if(result is not null)
            {
                return CreatedAtAction(nameof(GetFactoryById), new { id = result.Id }, result);
            }

            return null;
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult<bool>> DeleteFactory(int id)
        {
            var result = await _service.DeleteFactory(id);

            if (result == false) return NotFound("Factory with this Id not Found");

            return Ok(result);
        }
    }
}
