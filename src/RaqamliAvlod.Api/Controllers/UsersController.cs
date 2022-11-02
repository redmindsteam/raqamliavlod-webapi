using Microsoft.AspNetCore.Mvc;
using RaqamliAvlod.Application.Utils;
using RaqamliAvlod.Application.ViewModels.Users.Commands;

namespace RaqamliAvlod.Api.Controllers;

[Route("api/users")]
[ApiController]
public class UsersController : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetAllAsync([FromQuery] PaginationParams @params)
    {
        return Ok();
    }

    [HttpGet("{userId}")]
    public async Task<IActionResult> GetAsync(long userId)
    {
        return Ok();
    }

    [HttpPut("{userId}")]
    public async Task<IActionResult> UpdateAsync(long userId, [FromForm] UserUpdateViewModel userUpdateViewModel)
    {
        return Ok();
    }

    [HttpGet("search")]
    public async Task<IActionResult> SearchAsync(string search, [FromQuery] PaginationParams @params)
    {
        return Ok();
    }

    [HttpGet("{userId}/submuissions")]
    public async Task<IActionResult> GetSubmissionsAsync(long userId, [FromQuery] PaginationParams @params)
    {
        return Ok();
    }
}
