using Application.Common.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Project_API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    private readonly IAuthService _authService;

    public AuthController(IAuthService authService)
    {
        _authService = authService;
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login([FromBody] LoginRequest request)
    {
        var token = await _authService.LoginAsync(request.Username, request.Password);

        if (token == null)
        {
            return Unauthorized(new { message = "Invalid credentials" });
        }

        return Ok(new { token });
    }

    [HttpGet("test-auth")]
    [Microsoft.AspNetCore.Authorization.Authorize]
    public IActionResult TestAuth()
    {
        return Ok(new { message = "You are authorized!", user = User.Identity?.Name });
    }
}

public class LoginRequest
{
    public string Username { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
}
