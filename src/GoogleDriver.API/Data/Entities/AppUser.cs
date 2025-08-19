using Microsoft.AspNetCore.Identity;

namespace GoogleDriver.API.Data.Entities;

public class AppUser : IdentityUser<Guid>
{
    public string DisplayName { get; set; }


    public RootFolder RootFolder { get; set; }
}
