using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RaqamliAvlod.Application.Utils;
using RaqamliAvlod.Infrastructure.Service.Dtos;
using RaqamliAvlod.Infrastructure.Service.Dtos.Accounts;
using RaqamliAvlod.Infrastructure.Service.Interfaces.Common;
using RaqamliAvlod.Infrastructure.Service.Interfaces.Users;

namespace RaqamliAvlod.Api.Controllers;

[Route("api/users")]
[ApiController]
public class UsersController : ControllerBase
{
    private readonly IUserService _userService;
    private readonly IIdentityHelperService _identityHelperService;

    public UsersController(IUserService userService, IIdentityHelperService identityHelperService)
    {
        _userService = userService;
        _identityHelperService = identityHelperService;
    }

    [HttpGet, AllowAnonymous]
    public async Task<IActionResult> GetAllAsync([FromQuery] PaginationParams @params)
        => Ok(await _userService.GetAllAsync(@params));

    [HttpGet("{userId}"), AllowAnonymous]
    public async Task<IActionResult> GetIdAsync(long userId)
        => Ok(await _userService.GetIdAsync(userId));

    [HttpGet("username"), AllowAnonymous]
    public async Task<IActionResult> GetUsernameAsync(string username)
        => Ok(await _userService.GetUsernameAsync(username));

    [HttpPut, Authorize(Roles = "User, Admin, SuperAdmin")]
    public async Task<IActionResult> UpdateAsync([FromForm] UserUpdateDto userUpdateViewModel)
        => Ok(await _userService.UpdateAsync((long)_identityHelperService.GetUserId()!, userUpdateViewModel));

    [HttpDelete("{userId}"), Authorize(Roles = "Admin, SuperAdmin")]
    public async Task<IActionResult> DeleteAsync(long userId)
        => Ok(await _userService.DeleteAsync(userId));

    [HttpPost("images/upload"), Authorize(Roles = "Admin, User, SuperAdmin")]
    public async Task<IActionResult> ImageUpdateAsync([FromForm] ImageUploadDto dto)
        => Ok(await _userService.ImageUpdateAsync((long)_identityHelperService.GetUserId()!, dto));

    [HttpPatch("role/control"), Authorize(Roles = "SuperAdmin")]
    public async Task<IActionResult> RoleControlAsync(long userId, ushort roleNum)
        => Ok(await _userService.RoleControlAsync(userId, roleNum));

    [HttpGet("{userId}/submuissions")]
    public async Task<IActionResult> GetSubmissionsAsync(long userId, [FromQuery] PaginationParams @params)
    {
        return Ok();
    }

    [HttpGet("{salom}")]
    public async Task<IActionResult> GetR()
    {
        int i = 2;
        if (i == 1) return Ok();
        else return Unauthorized();
    }
}
