using Application.Common.DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace backend_web.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TestController : ControllerBase
{
    [Authorize]
    [HttpGet("protected-data")]
    public IActionResult GetProtectedData()
    {
        var data = new
        {
            Message = "This is protected data. You successfully authenticated with JWT!",
            User = User.Identity?.Name,
            Claims = User.Claims.Select(c => new { c.Type, c.Value })
        };

        return Ok(ApiResponse<object>.Ok(data, "Protected data retrieved successfully"));
    }

    [HttpGet("public-data")]
    public IActionResult GetPublicData()
    {
        var data = new { Message = "This is public data. Anyone can see this." };
        
        return Ok(ApiResponse<object>.Ok(data, "Public data retrieved successfully"));
    }
}
