using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace GoogleDriver.API.Data.Entities;

public class AppRole : IdentityRole<Guid>
{
    [Required]
    [MaxLength(200)]
    public required string DisplayName { get; set; }
}
