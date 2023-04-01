using API.DTOs;
using API.Services;
using Domain;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AccountController : ControllerBase
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly TokenService _tokenService;
        public AccountController(UserManager<AppUser> userManager, TokenService tokenService)
        {
            _tokenService = tokenService;
            _userManager = userManager;
        }
        [AllowAnonymous]
        [HttpPost("login")]
        public async Task<ActionResult<UserDTO>> Login(LoginDTO loginDTO)
        {
            var user = await _userManager.FindByEmailAsync(loginDTO.Email);
            if (user == null) return Unauthorized();
            var result = await _userManager.CheckPasswordAsync(user, loginDTO.Password);
            if (result)
            {
                return CreateObjectDTO(user);
            }
            return Unauthorized();
        }

        [AllowAnonymous]
        [HttpPost("Register")]
        public async Task<ActionResult<UserDTO>> Register(RegisterDTO registerDTO)
        {
            if (await _userManager.Users.AnyAsync(a => a.UserName == registerDTO.UserName))
            {
                return BadRequest("Username is already taken");
            }
            if (await _userManager.Users.AnyAsync(a => a.Email == registerDTO.Email))
            {
                return BadRequest("Email is already taken");
            }
            var user = new AppUser
            {
                DisplayName = registerDTO.DisplayName,
                Email = registerDTO.Email,
                UserName = registerDTO.UserName
            };
            var ret = await _userManager.CreateAsync(user, registerDTO.Password);
            if (ret.Succeeded)
            {
                return CreateObjectDTO(user);
            }
            return BadRequest(ret.Errors);
        }
        [AllowAnonymous]

        // [Authorize]
        // [HttpGet("GetCurrentUser")]
        [HttpGet]
        public async Task<ActionResult<UserDTO>> GetCurrentUser()
        {
            var user = await _userManager.FindByEmailAsync(User.FindFirstValue(ClaimTypes.Email));
            return CreateObjectDTO(user);
        }

        private UserDTO CreateObjectDTO(AppUser user)
        {
            return new UserDTO
            {
                DisplayName = user.DisplayName,
                Image = null,
                Token = _tokenService.CreateToken(user),
                UserName = user.UserName
            };
        }
    }
}