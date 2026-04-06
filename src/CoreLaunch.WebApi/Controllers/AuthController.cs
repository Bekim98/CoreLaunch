using CoreLaunch.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CoreLaunch.WebApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    private readonly IAuthService _authService;

    public AuthController(IAuthService authService)
    {
        _authService = authService;
    }

    [HttpPost("register")]
    public async Task<IActionResult> Register([FromBody] AuthRequest request)
    {
        var result = await _authService.RegisterAsync(request.Email, request.Password);
        if (!result.Success) return BadRequest(result.Error);
        return Ok(result);
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login([FromBody] AuthRequest request)
    {
        var result = await _authService.LoginAsync(request.Email, request.Password);
        if (!result.Success) return Unauthorized(result.Error);
        return Ok(result);
    }

    [HttpPost("refresh")]
    public async Task<IActionResult> Refresh([FromBody] RefreshRequest request)
    {
        var result = await _authService.RefreshTokenAsync(request.RefreshToken);
        if (!result.Success) return Unauthorized(result.Error);
        return Ok(result);
    }
}

public record AuthRequest(string Email, string Password);
public record RefreshRequest(string RefreshToken);
