using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RaqamliAvlod.Application.Utils;
using RaqamliAvlod.Application.ViewModels.Users.Commands;

namespace RaqamliAvlod.Api.Controllers;

[Route("api/users")]
[ApiController]
public class UsersController : ControllerBase
{
    [HttpGet, AllowAnonymous]
    public async Task<IActionResult> GetAllAsync([FromBody] PaginationParams @params)
    {
        return Ok();
    }

    [HttpGet("{id}"), AllowAnonymous]
    public async Task<IActionResult> GetAsync(long id)
    {
        return Ok();
    }

    [HttpPut("{id}"), Authorize(Roles = "User, Admin")]
    public async Task<IActionResult> UpdateAsync(long id, [FromForm] UserUpdateViewModel userUpdateViewModel)
    {
        return Ok();
    }

    [HttpPost, Authorize(Roles = "User, Admin")]
    public async Task<IActionResult> CreateAsync([FromForm] UserCreateViewModel userCreateViewModel)
    {
        return Ok();
    }

    [HttpGet("search/{search}")]
    public async Task<IActionResult> SearchAsync([FromQuery] PaginationParams @params, string search)
    {
        return Ok();
    }

    [HttpGet("{userId}/submuissions")]
    public async Task<IActionResult> GetSubmissionsAsync(long userId, [FromQuery] PaginationParams @params)
    {
        return Ok();
    }

    //[HttpPatch("password/{id")]
}
