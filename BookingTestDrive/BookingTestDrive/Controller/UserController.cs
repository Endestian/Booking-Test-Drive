using BookingTestDrive.Dto.Common;
using BookingTestDrive.Dto.user;
using BookingTestDrive.Model;
using BookingTestDrive.Repository;
using BookingTestDrive.Service.userService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BookingTestDrive.Controller;

[Route("api/[controller]")]
[ApiController]
public class UserController : ControllerBase
{
    
    private readonly UserService _userService;

    public UserController(UserService userService)
    {
        _userService = userService;
    }
    
    [HttpPost("register")]
    public async Task<ActionResult<CommonResponseDto>> Post([FromBody] RegisterUserDto request)
    {
        var result = await _userService.Register(request);
        return result;
    }
    
    [HttpPost("login")]
    public async Task<ActionResult<CommonResponseDto>> Post([FromBody] LoginDto request)
    {
        var result = await _userService.Login(request);
        return result;
    }
    
}