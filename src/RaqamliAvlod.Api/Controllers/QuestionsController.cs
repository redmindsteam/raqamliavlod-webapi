using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RaqamliAvlod.Application.Utils;
using RaqamliAvlod.Application.ViewModels.Questions.Commands;
#pragma warning disable
namespace RaqamliAvlod.Api.Controllers;

[Route("api/questions")]
[ApiController]
public class QuestionsController : ControllerBase
{
    [HttpGet, AllowAnonymous]
    public async Task<IActionResult> GetAllAsync([FromQuery] PaginationParams @params)
    {
        return Ok();
    }

    [HttpGet("{id}"), AllowAnonymous]
    public async Task<IActionResult> GetAsync(long id)
    {
        return Ok();
    }

    [HttpPost, AllowAnonymous]
    public async Task<IActionResult> CreateAsync([FromForm] QuestionCreateViewModel questionCreateViewModel)
    {
        return Ok();
    }

    [HttpPatch("{id}"), Authorize(Roles = "User, Admin")]
    public async Task<IActionResult> UpdateAsync(long id, [FromBody] QuestionCreateViewModel questionUpdateViewModel)
    {
        return Ok();
    }

    [HttpDelete("{id}"), Authorize(Roles = "User, Admin")]
    public async Task<IActionResult> DeleteAsync(long id)
    {
        return Ok();
    }

    [HttpPost("{id}/views"), Authorize(Roles = "Admin")]
    public async Task<IActionResult> CreateViewsAsync(long id)
    {
        return Ok();
    }

    [HttpPost("{id}/answers"), Authorize(Roles = "User, Admin")]
    public async Task<IActionResult> CreateAnswerAsync(long id)
    {
        return Ok();
    }

    [HttpGet("answers/{answerId}"), AllowAnonymous]
    public async Task<IActionResult> GetAnswerAsync(long answerId)
    {
        return Ok();
    }

    [HttpPut("answers/{answerId}"), Authorize(Roles = "User, Admin")]
    public async Task<IActionResult> UpdateAnswerAsync(long answerId)
    {
        return Ok();
    }

    [HttpDelete("answers/{answerId}"), Authorize(Roles = "User, Admin")]
    public async Task<IActionResult> DeleteAsnwerAsync(long answerId)
    {
        return Ok();
    }

    [HttpGet("search/{search}"), AllowAnonymous]
    public async Task<IActionResult> GetSearchAsync(string search)
    {
        return Ok();
    }
}
