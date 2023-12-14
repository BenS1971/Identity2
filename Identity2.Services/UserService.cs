using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Identity2.Data;
using Identity2.Data.Entities;
using Identity2.Models.User;

namespace Identity2.Services.User;

public class UserService : IUserService
{
    private readonly AppDbContext _ctx;
    private readonly UserManager<UserEntity> _userManager;
    
}