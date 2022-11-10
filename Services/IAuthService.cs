using DotNet_JWT_6.Model;

namespace DotNet_JWT_6.Services
{
    public interface IAuthService
    {
        Task<AuthModel> RegisterAsync(RegisterModel model);
        Task<AuthModel> GetTokenAsync(TokenRequestModel model);
        Task<string> AddRoleAsync(AddRoleModel model);
        Task<AuthModel> RefreshTokenAsync(string token);
        // Task<bool> RevokeTokenAsync(string token);
    }
}