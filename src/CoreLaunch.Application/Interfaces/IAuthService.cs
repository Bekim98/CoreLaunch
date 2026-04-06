namespace CoreLaunch.Application.Interfaces;

public interface IAuthService
{
    Task<AuthResult> RegisterAsync(string email, string password);
    Task<AuthResult> LoginAsync(string email, string password);
    Task<AuthResult> RefreshTokenAsync(string refreshToken);
}

public class AuthResult
{
    public bool Success { get; set; }
    public string? AccessToken { get; set; }
    public string? RefreshToken { get; set; }
    public string? Error { get; set; }
}
