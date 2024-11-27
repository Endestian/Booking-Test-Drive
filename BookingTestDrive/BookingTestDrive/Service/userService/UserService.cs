using BookingTestDrive.Dto.Common;
using BookingTestDrive.Dto.user;

namespace BookingTestDrive.Service.userService;

public interface UserService
{
    Task<CommonResponseDto> Register(RegisterUserDto request);
    Task<CommonResponseDto> Login(LoginDto request);
}