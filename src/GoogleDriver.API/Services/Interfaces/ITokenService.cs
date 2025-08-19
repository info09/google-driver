using GoogleDriver.API.Data.Entities;

namespace GoogleDriver.API.Services.Interfaces;

public interface ITokenService
{
    Task<string> CreateTokenAsync(AppUser appUser);

    Task<string> GenerateRefreshToken();
}
