using BookingTestDrive.Dto.Common;
using BookingTestDrive.Dto.user;
using BookingTestDrive.Model;
using BookingTestDrive.Repository;

namespace BookingTestDrive.Service.userService;

public class UserServiceImpl : UserService
{
    
    private readonly ApplicationDbContext _context;
    
    public UserServiceImpl(ApplicationDbContext context)
    {
        _context = context;
    }
    public async Task<CommonResponseDto> Register(RegisterUserDto request)
    {
        CommonResponseDto response = new CommonResponseDto();
        
        var userExist = await _context.UserModels.FindAsync(request.Username);
        if (userExist == null)
        {
            Guid uuid = Guid.NewGuid();
            UserModel userModelRegist = new UserModel();
            userModelRegist.Username = request.Username;
            userModelRegist.Password = request.Password;
            userModelRegist.Role = request.Role;
            userModelRegist.CustomerName = request.CustomerName;
            userModelRegist.CustomerEmail = request.CustomerEmail;
            userModelRegist.CustomerPhone = request.CustomerPhone;
            userModelRegist.Id = uuid.ToString();
            await _context.UserModels.AddAsync(userModelRegist);

            response.responseCode = 00;
            response.message = "Success";
            response.codeSystem = 200;
            response.result = userModelRegist;
            return response;
        }
        else
        {
            response.responseCode = 400;
            response.codeSystem = 200;
            response.message = "Username or password is incorrect";
            return response;
        }
    }
    
    public async Task<CommonResponseDto> Login(LoginDto request)
    {
        CommonResponseDto response = new CommonResponseDto();
        
        var userExist = await _context.UserModels.FindAsync(request.Username, request.Password);
        if (userExist != null)
        {
            response.responseCode = 00;
            response.message = "Success";
            response.codeSystem = 200;
            response.result = userExist;
            return response;
        }
        else
        {
            response.responseCode = 400;
            response.codeSystem = 200;
            response.message = "Username or password is incorrect";
            return response;
        }
    }
}