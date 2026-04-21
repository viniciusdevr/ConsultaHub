using ConsultaHub.Models.Entities;
using ConsultaHub.View.DTOs;

namespace ConsultaHub.Services.Auth
{
    public interface IAuthService
    {
        Task<User> RegisterAsync(UserDto request);
        Task<string?> LoginAsync(UserDto request);
    }
}
