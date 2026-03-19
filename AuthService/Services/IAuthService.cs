using AuthService.DTOs;

namespace AuthService.Services;

public interface IAuthService
{
    Task<(bool Success, string Message)> RegisterAsync(RegisterRequestDto dto);
    Task<(bool Success, string Message)> RegisterAdminAsync(AdminRegisterRequestDto dto);

    Task<(bool Success, AuthResponseDto? Data, string Message)> LoginAsync(LoginRequestDto dto);
}