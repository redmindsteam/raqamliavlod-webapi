using Microsoft.AspNetCore.Mvc;
using RaqamliAvlod.Application.Utils;
using RaqamliAvlod.Infrastructure.Service.Dtos;
using RaqamliAvlod.Infrastructure.Service.Interfaces.Common;
using RaqamliAvlod.Infrastructure.Service.Interfaces.Contests;

namespace RaqamliAvlod.Api.Controllers;

[Route("api/contests")]
[ApiController]
public class ContestsController : ControllerBase
{
    private readonly IContestService _contestService;
    private readonly IIdentityHelperService _identityHelper;

    public ContestsController(IContestService contestService, IIdentityHelperService service)
    {
        _contestService = contestService;
        _identityHelper = service;
    }

    [HttpGet]
    public async Task<IActionResult> GetAllAsync([FromQuery] PaginationParams @params)
        => Ok(await _contestService.GetAllAsync(@params));

    [HttpGet("{contestId}")]
    public async Task<IActionResult> GetAsync(long contestId)
        => Ok(await _contestService.GetAsync(contestId));

    [HttpPost]
    public async Task<IActionResult> CreateAsync([FromForm] ContestCreateDto contestCreateViewModel)
        => Ok(await _contestService.CreateAsync(contestCreateViewModel));

    [HttpPut("{contestId}")]
    public async Task<IActionResult> UpdateAsync(long contestId, [FromForm] ContestCreateDto contestUpdateViewModel)
        => Ok(await _contestService.UpdateAsync(contestId, contestUpdateViewModel));

    [HttpDelete("{contestId}")]
    public async Task<IActionResult> DeleteAsync(long contestId)
        => Ok(await _contestService.DeleteAsync(contestId));

    [HttpPost("{contestId}/register")]
    public async Task<IActionResult> RegistrateAsync(long contestId)
       => Ok(await _contestService.RegisterAsync(contestId, _identityHelper.GetUserId() ?? 0));

    [HttpPost("submissions")]
    public async Task<IActionResult> CreateSubmissionsAsync([FromForm] ContestSubmissionCreateDto viewModel)
    {
        return Ok();
    }

    [HttpPost("problemsets")]
    public async Task<IActionResult> CreateProblemSetAsync([FromForm] ContestProblemSetCreateDto createViewModel)
        => Ok(await _contestService.CreateProblemSetAsync(createViewModel));

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
