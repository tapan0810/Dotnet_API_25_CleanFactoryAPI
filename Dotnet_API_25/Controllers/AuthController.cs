using Dotnet_API_25.Entities.DTOs.UserDto;
using Dotnet_API_25.Services;
using Microsoft.AspNetCore.Mvc;

namespace Dotnet_API_25.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController(IAuthService authService) : ControllerBase
    {
        [HttpPost("register")]
        public async Task<IActionResult> Register(RegisterDto dto)
        {
            try
            {
                var result = await authService.Register(dto);
                return Ok(new { Message = result });
            }
            catch (Exception ex)
            {
                return BadRequest(new { Message = ex.Message });
            }
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginDto dto)
        {
            var result = await authService.Login(dto);
            if (result == null)
            {
                return Unauthorized("Invalid credentials");
            }
            return Ok(new { Message = "Login successful", Data = result });
        }
    }
}