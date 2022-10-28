using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RaqamliAvlod.Application.Utils;
using RaqamliAvlod.Application.ViewModels.Courses.Commands;
#pragma warning disable
namespace RaqamliAvlod.Api.Controllers;

[Route("api/courses")]
[ApiController]
public class CoursesController : ControllerBase
{
    [HttpGet, AllowAnonymous]
    public async Task<IActionResult> GetAllAsync([FromQuery] PaginationParams @params, string searchText)
    {
        return Ok();
    }

    [HttpGet("{id}"), AllowAnonymous]
    public async Task<IActionResult> GetAsync(long id)
    {
        return Ok();
    }

    [HttpPost, Authorize(Roles = "User, Admin")]
    public async Task<IActionResult> CreateAsync([FromForm] CourseCreateViewModel courseCreateViewModel)
    {
        return Ok();
    }

    [HttpDelete("{id}"), Authorize(Roles = "Admin")]
    public async Task<IActionResult> DeleteAsync(long id)
    {
        return Ok();
    }

    [HttpPatch("{id}"), Authorize(Roles = "User, Admin")]
    public async Task<IActionResult> UpdateAsync(long id, [FromForm] CourseCreateViewModel courseUpdateViewModel)
    {
        return Ok();
    }

    [HttpPost("{id}/comments"), Authorize(Roles = "User, Admin")]
    public async Task<IActionResult> CreateCommentAsync(long id, [FromBody] CourseCommentCreateViewModel courseCommentCreateViewModel)
    {
        return Ok();
    }

    [HttpGet("{id}/comments"), AllowAnonymous]
    public async Task<IActionResult> GetAllCommentsAsync([FromQuery] PaginationParams @params, long id)
    {
        return Ok();
    }

    [HttpDelete("{id}/comments/{commentId}"), Authorize(Roles = ("User, Admin"))]
    public async Task<IActionResult> DeleteCommentAsync(long id, long commentId)
    {
        return Ok();
    }

    [HttpGet("search/{search}"), AllowAnonymous]
    public async Task<IActionResult> SearchAsync([FromQuery] PaginationParams @params, string search)
    {
        return Ok();
    }

    [HttpPost("videos"), AllowAnonymous]
    public async Task<IActionResult> CreateCourseVideoAsync([FromForm] CourseVideoCreateViewModel courseVideoCreateViewModel)
    {
        return Ok();
    }

    [HttpPatch("videos"), AllowAnonymous]
    public async Task<IActionResult> UpdateCourseVideoAsync([FromForm] CourseVideoCreateViewModel courseVideoUpdateViewModel)
    {
        return Ok();
    }
}
