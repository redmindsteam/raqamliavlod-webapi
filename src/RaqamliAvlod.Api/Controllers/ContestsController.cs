using Microsoft.AspNetCore.Mvc;
using RaqamliAvlod.Application.Utils;
using RaqamliAvlod.Application.ViewModels.Contests.Commands;
using RaqamliAvlod.Application.ViewModels.ProblemSets.Commands;
using RaqamliAvlod.Application.ViewModels.Submissions.Commands;
namespace RaqamliAvlod.Api.Controllers;

[Route("api/contests")]
[ApiController]
public class ContestsController : ControllerBase
{

    [HttpGet]
    public async Task<IActionResult> GetAllAsync([FromQuery] PaginationParams @params)
    {
        return Ok();
    }

    [HttpGet("{contestId}")]
    public async Task<IActionResult> GetAsync(long contestId)
    {
        return Ok();
    }

    [HttpPost]
    public async Task<IActionResult> CreateAsync([FromBody] ContestCreateViewModel contestCreateViewModel)
    {
        return Ok();
    }

    [HttpPut("{contestId}")]
    public async Task<IActionResult> UpdateAsync(long contestId, [FromBody] ContestCreateViewModel contestUpdateViewModel)
    {
        return Ok();
    }

    [HttpDelete("{contestId}")]
    public async Task<IActionResult> DeleteAsync(long contestId)
    {
        return Ok();
    }

    [HttpPost("registrate")]
    public async Task<IActionResult> RegistrateAsync(long contestId)
    {
        return Ok();
    }

    [HttpPost("submissions")]
    public async Task<IActionResult> CreateSubmissionsAsync([FromForm] ContestSubmissionCreateViewModel viewModel)
    {
        return Ok();
    }

    [HttpPost("problemsets")]
    public async Task<IActionResult> CreateProblemSetAsync([FromForm] ContestProblemSetCreateViewModel createViewModel)
    {
        return Ok();
    }

    [HttpPost("standings/calculate")]
    public async Task<IActionResult> StandingsAsync(long contestId)
    {
        return Ok();
    }

    [HttpGet("{contestId}/submissions")]
    public async Task<IActionResult> GetAllSubmissionsAsync([FromQuery] PaginationParams @params, long contestId)
    {
        return Ok();
    }

    [HttpGet("{contestId}/users/{userId}/submissions")]

    public async Task<IActionResult> GetSubmissionsAsync([FromQuery] PaginationParams @params, 
        long contestId, long userId)
    {
        return Ok();
    }

    [HttpGet("{contestId}/problemsets")]
    public async Task<IActionResult> GetAllProblemSetsAsync(long contestId)
    {
        return Ok();
    }

    [HttpGet("{contestId}/problemsets/{problemSetId}")]
    public async Task<IActionResult> GetProblemSetAsync(long contestId, long problemSetId)
    {
        return Ok();
    }

    [HttpGet("{contestId}/participants")]
    public async Task<IActionResult> GetParticipantsAsync([FromQuery] PaginationParams @params, long contestId)
    {
        return Ok();
    }

    [HttpGet("{contestId}/standings")]
    public async Task<IActionResult> StandingsAsync([FromQuery] PaginationParams @params, long contestId)
    {
        return Ok();
    }
}
