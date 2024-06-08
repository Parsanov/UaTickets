using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Model.Dtos;
using Model.Interfaces;
using Model.Model;

namespace UaTicketsAPI.Controllers
{
    public class AccountController : Controller
    {

        private readonly UserManager<AppUser> _userManager;
        private readonly ITokenService _tokenService;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly IDecodingToken _decodingToken;

        public AccountController(UserManager<AppUser> userManager, ITokenService tokenService, SignInManager<AppUser> signInManager,
            IDecodingToken decodingToken)
        {
            _userManager = userManager;
            _tokenService = tokenService;
            _signInManager = signInManager;
            _decodingToken = decodingToken;
        }


        [HttpPost("Login")]
        public async Task<IActionResult> Login([FromBody] LoginDto loginDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var user = await _userManager.FindByNameAsync(loginDto.UserName);
            if (user == null) return Unauthorized("Invalid User Name!");

            var result = await _signInManager.CheckPasswordSignInAsync(user, loginDto.Password, false);
            if (!result.Succeeded) return Unauthorized("User name not found and/or password is incorrect");



            return Ok(new NewUserDto
            {
                UserName = user.UserName,
                Email = user.Email,
                Token = _tokenService.CreateToken(user)
            });
        }



        [HttpPost("Register")]
        public async Task<IActionResult> Register([FromBody] RegisterDto registerDto)
        {
            try
            {

                var appUser = new AppUser()
                {
                    UserName = registerDto.Username,
                    Email = registerDto.Email,
                };

                var createUser = await _userManager.CreateAsync(appUser, registerDto.Password);

                if (createUser.Succeeded)
                {
                    var roleResult = await _userManager.AddToRoleAsync(appUser, "User");
                    if (roleResult.Succeeded)
                    {
                        return Ok(
                          new NewUserDto
                          {
                              UserName = appUser.UserName,
                              Email = appUser.Email,
                              Token = _tokenService.CreateToken(appUser)
                          }
                        );
                    }
                    else
                    {
                        return StatusCode(500, roleResult.Errors);
                    }
                }
                else
                {
                    return StatusCode(500, createUser.Errors);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }



        [HttpPost("JwtData")]
        public async Task<IActionResult> JwtData([FromBody] JWTDataDto token)
        {

            if (token == null)
            {
                return Ok();
            }

            var data = _decodingToken.GetUserDto(token.ToString());


            if (data != null)
            {
                return Ok(data);
            }

            return BadRequest();
        }



    }
}
