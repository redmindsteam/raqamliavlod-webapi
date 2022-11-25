using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RaqamliAvlod.Application.Utils;
using RaqamliAvlod.Infrastructure.Service.Interfaces.Common;
using RaqamliAvlod.Infrastructure.Service.Interfaces.Contests;

namespace RaqamliAvlod.Api.Controllers.Public
{
    [Route("api/contests"), ApiController, AllowAnonymous]
    public partial class ContestsController : ControllerBase
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
        public async Task<IActionResult> GetStandingsAsync([FromQuery] PaginationParams @params, long contestId)
        {
            return Ok();
        }
    }
}
