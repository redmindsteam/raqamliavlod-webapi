using Microsoft.AspNetCore.Mvc;
using RaqamliAvlod.Application.Utils;
using RaqamliAvlod.Application.ViewModels.Questions.Commands;

namespace RaqamliAvlod.Api.Controllers;

[Route("api/questions")]
[ApiController]
public class QuestionsController : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetAllAsync([FromQuery] PaginationParams @params)
    {
        return Ok();
    }

    [HttpGet("{questionId}")]
    public async Task<IActionResult> GetAsync(long questionId)
    {
        return Ok();
    }

    [HttpPost]
    public async Task<IActionResult> CreateAsync([FromForm] QuestionCreateViewModel questionCreateViewModel)
    {
        return Ok();
    }

    [HttpPatch("{questionId}")]
    public async Task<IActionResult> UpdateAsync(long questionId, [FromBody] QuestionCreateViewModel questionUpdateViewModel)
    {
        return Ok();
    }

    [HttpDelete("{questionId}")]
    public async Task<IActionResult> DeleteAsync(long questionId)
    {
        return Ok();
    }

    [HttpPost("{questionId}/views")]
    public async Task<IActionResult> CreateViewsAsync(long questionId)
    {
        return Ok();
    }

    [HttpPost("{questionId}/answers")]
    public async Task<IActionResult> CreateAnswerAsync(long questionId)
    {
        return Ok();
    }

    [HttpGet("answers/{answerId}")]
    public async Task<IActionResult> GetAnswerAsync(long answerId)
    {
        return Ok();
    }

    [HttpPut("answers/{answerId}")]
    public async Task<IActionResult> UpdateAnswerAsync(long answerId)
    {
        return Ok();
    }

    [HttpDelete("answers/{answerId}")]
    public async Task<IActionResult> DeleteAsnwerAsync(long answerId)
    {
        return Ok();
    }

    [HttpGet("search/{search}")]
    public async Task<IActionResult> GetSearchAsync(string search)
    {
        return Ok();
    }
}
