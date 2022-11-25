using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RaqamliAvlod.Application.Utils;
using RaqamliAvlod.Infrastructure.Service.Dtos;
using RaqamliAvlod.Infrastructure.Service.Interfaces.Common;
using RaqamliAvlod.Infrastructure.Service.Interfaces.ProblemSets;

namespace RaqamliAvlod.Api.Controllers;

[Route("api/problemSets")]
[ApiController]
public class ProblemSetsController : ControllerBase
{
    private readonly IProblemSetService _problemSetService;
    private readonly IIdentityHelperService _identityService;
    private readonly IProblemSetTestService _testService;

    public ProblemSetsController(IProblemSetService problemSetService, 
        IIdentityHelperService identityHelperService, IProblemSetTestService testService)
    {
        this._problemSetService = problemSetService;
        this._identityService = identityHelperService;
        this._testService = testService;
    }

    [HttpGet, AllowAnonymous]
    public async Task<IActionResult> GetAllAsync([FromQuery] PaginationParams @params)
        => Ok(await _problemSetService.GetAllAsync(@params, _identityService.GetUserId()));

    [HttpGet("{problemSetId}"), AllowAnonymous]
    public async Task<IActionResult> GetAsync(long problemSetId)
        => Ok(await _problemSetService.GetAsync(problemSetId));

    [HttpPost, Authorize(Roles = "Admin, SuperAdmin")]
    public async Task<IActionResult> CreateAsync([FromForm] ProblemSetCreateDto problemSetCreateDto)
        => Ok(await _problemSetService.CreateAsync(problemSetCreateDto));

    [HttpPut("{problemSetId}"), Authorize(Roles = "Admin, SuperAdmin")]
    public async Task<IActionResult> UpdateAsync(long problemSetId, [FromForm] ProblemSetCreateDto problemSetCreateDto)
        => Ok(await _problemSetService.UpdateAsync(problemSetId, problemSetCreateDto));

    [HttpDelete("{problemSetId}"), Authorize(Roles = "Admin, SuperAdmin")]
    public async Task<IActionResult> DeleteAsync(long problemSetId)
        => Ok(await _problemSetService.DeleteAsync(problemSetId));

    [HttpGet("search"), AllowAnonymous]
    public async Task<IActionResult> SearchAsync(string search, [FromQuery] PaginationParams @params)
    {
        return Ok();
    }

    [HttpGet("{problemSetId}/tests"), AllowAnonymous]
    public async Task<IActionResult> GetProblemSetTestsAsync(long problemSetId)
        => Ok(await _testService.GetAllAsync(problemSetId));

    [HttpGet("tests/{testId}"), AllowAnonymous]
    public async Task<IActionResult> GetProblemSetsTestAsync(long testId)
      => Ok(await _testService.GetAsync(testId));

    [HttpPost("tests"), Authorize(Roles = "Admin, SuperAdmin")]
    public async Task<IActionResult> CreateProblemSetsTestAsync([FromForm] ProblemSetTestCreateDto viewModel)
        => Ok(await _testService.CreateAsync(viewModel));

    [HttpPut("tests/{testId}"), Authorize(Roles = "Admin, SuperAdmin")]
    public async Task<IActionResult> UpdateProblemSetsTestAsync(long testId,
        [FromForm] ProblemSetTestCreateDto viewModel)
        => Ok(await _testService.UpdateAsync(testId, viewModel));

    [HttpDelete("tests/{testId}"), Authorize(Roles = "Admin, SuperAdmin")]
    public async Task<IActionResult> DeleteProblemSetsTestAsync(long testId)
        => Ok(await _testService.DeleteAsync(testId));


    [HttpPost("submissions")]
    public async Task<IActionResult> CreateSubmissionAsync(ProblemSetSubmissionCreateDto viewModel)
    {
        return Ok();
    }

    [HttpGet("{problemSetId}/submissions")]
    public async Task<IActionResult> GetAllSubmissions([FromQuery] PaginationParams @params, long problemSetId)
    {
        return Ok();
    }
}