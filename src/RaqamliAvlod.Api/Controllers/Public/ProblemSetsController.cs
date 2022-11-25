using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RaqamliAvlod.Application.Utils;
using RaqamliAvlod.Infrastructure.Service.Interfaces.Common;
using RaqamliAvlod.Infrastructure.Service.Interfaces.ProblemSets;

namespace RaqamliAvlod.Api.Controllers.Public;

[Route("api/problemSets"), ApiController, AllowAnonymous]
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

    [HttpGet]
    public async Task<IActionResult> GetAllAsync([FromQuery] PaginationParams @params)
        => Ok(await _problemSetService.GetAllAsync(@params, _identityService.GetUserId()));

    [HttpGet("{problemSetId}")]
    public async Task<IActionResult> GetAsync(long problemSetId)
        => Ok(await _problemSetService.GetAsync(problemSetId));

    [HttpGet("search"), AllowAnonymous]
    public async Task<IActionResult> SearchAsync(string search, [FromQuery] PaginationParams @params)
        => Ok();

    [HttpGet("{problemSetId}/tests")]
    public async Task<IActionResult> GetProblemSetTestsAsync(long problemSetId)
        => Ok(await _testService.GetAllAsync(problemSetId));

    [HttpGet("tests/{testId}")]
    public async Task<IActionResult> GetProblemSetsTestAsync(long testId)
       => Ok(await _testService.GetAsync(testId));
}
