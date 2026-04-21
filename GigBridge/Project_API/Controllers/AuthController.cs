using Application.Common.Interfaces;
using Application.Common.Models;
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
            return Unauthorized(ApiResponse<object>.Error(401, "Invalid credentials"));
        }

        return Ok(ApiResponse<object>.Ok(new { token }, "Login successful"));
    }

    [HttpGet("test-auth")]
    [Microsoft.AspNetCore.Authorization.Authorize]
    public IActionResult TestAuth()
    {
        var data = new { message = "You are authorized!", user = User.Identity?.Name };
        return Ok(ApiResponse<object>.Ok(data, "Authorization verified"));
    }
}

//{
//  "success": true,
//  "statusCode": 200,
//  "message": "Login successful",
//  "data": { "token": "..." },
//  "errors": null,
//  "timestamp": "2026-04-21T17:36:00Z"
//}


public class LoginRequest
{
    public string Username { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
}
