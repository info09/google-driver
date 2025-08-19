using GoogleDriver.API.Data.Entities;
using GoogleDriver.API.Dtos;

namespace GoogleDriver.API.Helpers;

public class ShareUrlResolver
{
    private readonly IConfiguration _config;
    public ShareUrlResolver(IConfiguration config)
    {
        _config = config;
    }

    public SharedToUser Map(SharedToUserAddDto dto)
    {
        if (dto == null) return null;

        return new SharedToUser
        {
            OwnerUserName = dto.OwnerUserName,
            SharedUserName = string.Join(",", dto.SharedUserName),
            // Ghép URL
            Url = string.IsNullOrEmpty(dto.Url)
                ? null
                : $"{_config["ApiUrl"]}huytq/Shared/{dto.Url}"
        };
    }
}
