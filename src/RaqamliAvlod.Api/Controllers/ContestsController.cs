using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RaqamliAvlod.Application.Utils;
using RaqamliAvlod.Application.ViewModels.Contests.Commands;
using RaqamliAvlod.Application.ViewModels.Submissions.Commands;
#pragma warning disable
namespace RaqamliAvlod.Api.Controllers;

[Route("api/contests")]
[ApiController]
public class ContestsController : ControllerBase
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

    [HttpPost, Authorize(Roles = "User, Admin")]
    public async Task<IActionResult> CreateAsync([FromBody] ContestCreateViewModel contestCreateViewModel)
    {
        return Ok();
    }

    [HttpPut("{id}"), Authorize(Roles = "User, Admin")]
    public async Task<IActionResult> UpdateAsync(long id, [FromBody] ContestCreateViewModel contestUpdateViewModel)
    {
        return Ok();
    }

    [HttpDelete("{id}"), Authorize(Roles = "Admin")]
    public async Task<IActionResult> DeleteAsync(long id)
    {
        return Ok();
    }

    [HttpPost("registrate"), Authorize(Roles = "User, Admin")]
    public async Task<IActionResult> RegistrateAsync(long contestId)
    {
        return Ok();
    }

    [HttpPost("submissions"), Authorize(Roles = "User, Admin")]
    public async Task<IActionResult> SubmissionsAsync([FromForm] ContestSubmissionCreateViewModel viewModel)
    {
        return Ok();
    }

    [HttpPost("standings"), Authorize(Roles = "User, Admin")]
    public async Task<IActionResult> StandingsAsync(long contestId)
    {
        return Ok();
    }

    [HttpGet("{contestId}/submissions"), AllowAnonymous]
    public async Task<IActionResult> GetAllSubmissionsAsync([FromQuery] PaginationParams @params, long contestId)
    {
        return Ok();
    }

    [HttpGet("{contestId}/users/{userId}/submissions")]
    public async Task<IActionResult> GetSubmissionAsync([FromQuery] PaginationParams @params, 
        long contestId, long userId)
    {
        return Ok();
    }

    [HttpGet("{contestId}/problemsets")]
    public async Task<IActionResult> GetAllProblemSetsAsync([FromQuery] PaginationParams @params, long contestId)
    {
        return Ok();
    }

    [HttpGet("{contestId}/problemsets/{problemSetId}")]
    public async Task<IActionResult> GetProblemSetAsync(long contestId, long problemSetId)
    {
        return Ok();
    }

    [HttpGet("{contestId}/participants")]
    public async Task<IActionResult> ParticipantsAsync([FromQuery] PaginationParams @params, long contestId)
    {
        return Ok();
    }

    [HttpGet("{contestId}/standings")]
    public async Task<IActionResult> StandingsAsync([FromQuery] PaginationParams @params, long contestId)
    {
        return Ok();
    }
}
