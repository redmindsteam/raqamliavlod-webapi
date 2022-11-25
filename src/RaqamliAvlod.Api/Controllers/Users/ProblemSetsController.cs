using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RaqamliAvlod.Infrastructure.Service.Dtos;
using RaqamliAvlod.Infrastructure.Service.Interfaces.Common;
using RaqamliAvlod.Infrastructure.Service.Interfaces.ProblemSets;
using System.Data;

namespace RaqamliAvlod.Api.Controllers.Users;
[Route("api/problemSets"), ApiController, Authorize(Roles = "SuperAdmin, Admin")]
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

    [HttpPost("submissions")]
    public async Task<IActionResult> CreateSubmissionAsync(ProblemSetSubmissionCreateDto viewModel)
        => Ok();
}
