using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RaqamliAvlod.Infrastructure.Service.Dtos;
using RaqamliAvlod.Infrastructure.Service.Interfaces.Common;
using RaqamliAvlod.Infrastructure.Service.Interfaces.Contests;

namespace RaqamliAvlod.Api.Controllers.Users
{
    [Route("api/contests"), ApiController, Authorize(Roles = "SuperAdmin, Admin, User")]
    public partial class ContestsController : ControllerBase
    {
        private readonly IContestService _contestService;
        private readonly IIdentityHelperService _identityHelper;

        public ContestsController(IContestService contestService, IIdentityHelperService service)
        {
            _contestService = contestService;
            _identityHelper = service;
        }

        [HttpPost("{contestId}/register")]
        public async Task<IActionResult> RegistrateAsync(long contestId)
            => Ok(await _contestService.RegisterAsync(contestId, _identityHelper.GetUserId() ?? 0));

        [HttpPost("submissions")]
        public async Task<IActionResult> CreateSubmissionsAsync([FromForm] ContestSubmissionCreateDto viewModel)
        {
            return Ok();
        }
    }
}
