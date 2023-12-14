using Microsoft.AspNetCore.Identity;

namespace Identity2.Data.Entities;

public class UserEntity : IdentityUser<int>
{
    public string? Name { get; set; }

    public DateTime DateCreated { get; set; }
}