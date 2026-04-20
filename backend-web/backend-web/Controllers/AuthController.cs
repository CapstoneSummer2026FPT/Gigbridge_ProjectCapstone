using Application.Common.DTOs;
using Application.Common.Interfaces;
using Microsoft.AspNetCore.Mvc;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace backend_web.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    private readonly IIdentityService _identityService;

    public AuthController(IIdentityService identityService)
    {
        _identityService = identityService;
    }

    [HttpPost("login-mock")]
    public IActionResult LoginMock([FromBody] LoginRequest request)
    {
        // Mocking user check for now since we're just testing JWT + Swagger
        if (request.Email == "test@example.com" && request.Password == "password")
        {
            var token = _identityService.GenerateToken("123456", "test@example.com", "Admin");
            return Ok(ApiResponse<object>.Ok(token, "Protected data retrieved successfully")); 
        }
        
        return Unauthorized();
    }
}

public class LoginRequest
{
    public string Email { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
}
