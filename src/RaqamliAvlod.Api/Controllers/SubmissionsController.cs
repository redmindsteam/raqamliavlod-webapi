using Microsoft.AspNetCore.Mvc;
using RaqamliAvlod.Application.Utils;

namespace RaqamliAvlod.Api.Controllers;

[Route("api/submissions")]
[ApiController]
public class SubmissionsController : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetAllAsync([FromQuery] PaginationParams @params)
    {
        return Ok();
    }

    [HttpGet("{submissionId}")]
    public async Task<IActionResult> GetAsync(long submissionId)
    {
        return Ok();
    }

    [HttpGet("{problemSetId}/{userId}")]
    public async Task<IActionResult> GetSubmissionUserAsync(long problemsetId,
        long userId, [FromQuery] PaginationParams @params)
    {
        return Ok();
    }
}
