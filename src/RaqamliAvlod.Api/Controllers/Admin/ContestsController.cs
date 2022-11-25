using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RaqamliAvlod.Infrastructure.Service.Dtos;
using RaqamliAvlod.Infrastructure.Service.Interfaces.Common;
using RaqamliAvlod.Infrastructure.Service.Interfaces.Contests;

namespace RaqamliAvlod.Api.Controllers.Admin;

[Route("api/contests"), ApiController, Authorize(Roles = "SuperAdmin, Admin")]
public partial class ContestsController : ControllerBase
{
    private readonly IContestService _contestService;
    private readonly IIdentityHelperService _identityHelper;

    public ContestsController(IContestService contestService, IIdentityHelperService service)
    {
        _contestService = contestService;
        _identityHelper = service;
    }

    [HttpPost]
    public async Task<IActionResult> CreateAsync([FromBody] ContestCreateDto contestCreateViewModel)
        => Ok(await _contestService.CreateAsync(contestCreateViewModel));

    [HttpPut("{contestId}")]
    public async Task<IActionResult> UpdateAsync(long contestId, [FromBody] ContestCreateDto contestUpdateViewModel)
        => Ok(await _contestService.UpdateAsync(contestId, contestUpdateViewModel));

    [HttpDelete("{contestId}")]
    public async Task<IActionResult> DeleteAsync(long contestId)
        => Ok(await _contestService.DeleteAsync(contestId));

    [HttpPost("standings/calculate")]
    public async Task<IActionResult> StandingsAsync(long contestId)
    {
        return Ok();
    }
}
