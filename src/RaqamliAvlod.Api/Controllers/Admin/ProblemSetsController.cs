using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RaqamliAvlod.Application.Utils;
using RaqamliAvlod.Infrastructure.Service.Dtos;
using RaqamliAvlod.Infrastructure.Service.Interfaces.Common;
using RaqamliAvlod.Infrastructure.Service.Interfaces.ProblemSets;

namespace RaqamliAvlod.Api.Controllers.Admin;

[Route("api/problemSets"), ApiController, Authorize(Roles ="SuperAdmin, Admin")]
public partial class ProblemSetsController : ControllerBase
{
    private readonly IProblemSetService _problemSetService;
    private readonly IIdentityHelperService _identityService;
    private readonly IProblemSetTestService _testService;

    public ProblemSetsController(IProblemSetService problemSetService,
        IIdentityHelperService identityHelperService, IProblemSetTestService testService)
    {
        _problemSetService = problemSetService;
        _identityService = identityHelperService;
        _testService = testService;
    }

    [HttpPost]
    public async Task<IActionResult> CreateAsync([FromForm] ProblemSetCreateDto problemSetCreateDto)
        => Ok(await _problemSetService.CreateAsync(problemSetCreateDto));

    [HttpPut("{problemSetId}")]
    public async Task<IActionResult> UpdateAsync(long problemSetId, [FromForm] ProblemSetCreateDto problemSetCreateDto)
        => Ok(await _problemSetService.UpdateAsync(problemSetId, problemSetCreateDto));

    [HttpDelete("{problemSetId}")]
    public async Task<IActionResult> DeleteAsync(long problemSetId)
        => Ok(await _problemSetService.DeleteAsync(problemSetId));

    [HttpPost("tests")]
    public async Task<IActionResult> CreateProblemSetsTestAsync([FromForm] ProblemSetTestCreateDto viewModel)
        => Ok(await _testService.CreateAsync(viewModel));

    [HttpPut("tests/{testId}")]
    public async Task<IActionResult> UpdateProblemSetsTestAsync(long testId,
        [FromForm] ProblemSetTestCreateDto viewModel)
        => Ok(await _testService.UpdateAsync(testId, viewModel));

    [HttpDelete("tests/{testId}")]
    public async Task<IActionResult> DeleteProblemSetsTestAsync(long testId)
        => Ok(await _testService.DeleteAsync(testId));

    [HttpGet("{problemSetId}/submissions")]
    public async Task<IActionResult> GetAllSubmissions([FromQuery] PaginationParams @params, long problemSetId)
        => Ok();
}