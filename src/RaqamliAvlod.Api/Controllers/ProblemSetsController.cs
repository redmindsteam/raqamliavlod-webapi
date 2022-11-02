using Microsoft.AspNetCore.Mvc;
using RaqamliAvlod.Application.Utils;
using RaqamliAvlod.Application.ViewModels.ProblemSets.Commands;
using RaqamliAvlod.Application.ViewModels.Submissions.Commands;

namespace RaqamliAvlod.Api.Controllers;

[Route("api/problemSets")]
[ApiController]
public class ProblemSetsController : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetAllAsync([FromQuery] PaginationParams @params)
    {
        return Ok();
    }

    [HttpGet("{problemSetId}")]
    public async Task<IActionResult> GetAsync(long problemSetId)
    {
        return Ok();
    }

    [HttpPost]
    public async Task<IActionResult> CreateAsync([FromForm] ProblemSetCreateViewModel problemSetCreateViewModel)
    {
        return Ok();
    }

    [HttpPut("{problemSetId}")]
    public async Task<IActionResult> UpdateAsync(long problemSetId, [FromForm] ProblemSetCreateViewModel problemSetCreateViewModel)
    {
        return Ok();
    }

    [HttpDelete("{problemSetId}")]
    public async Task<IActionResult> DeleteAsync(long problemSetId)
    {
        return Ok();
    }

    [HttpGet("search")]
    public async Task<IActionResult> SearchAsync(string search, [FromQuery] PaginationParams @params)
    {
        return Ok();
    }

    [HttpGet("{problemSetId}/tests")]
    public async Task<IActionResult> GetProblemSetTestsAsync(long problemSetId)
    {
        return Ok();
    }

    [HttpGet("tests/{testId}")]
    public async Task<IActionResult> GetProblemSetsTestAsync(long testId)
    {
        return Ok();
    }

    [HttpPost("tests")]
    public async Task<IActionResult> CreateProblemSetsTestAsync([FromForm] ProblemSetTestCreateViewModel viewModel)
    {
        return Ok();
    }

    [HttpPut("tests/{testId}")]
    public async Task<IActionResult> UpdateProblemSetsTestAsync(long testId,
        [FromForm] ProblemSetTestCreateViewModel problemSetTestCreateViewModel)
    {
        return Ok();
    }

    [HttpDelete("tests/{testId}")]
    public async Task<IActionResult> DeleteProblemSetsTestAsync(long testId)
    {
        return Ok();
    }

    [HttpPost("submissions")]
    public async Task<IActionResult> CreateSubmissionAsync(ProblemSetSubmissionCreateViewModel viewModel)
    {
        return Ok();
    }

    [HttpGet("{problemSetId}/submissions")]
    public async Task<IActionResult> GetAllSubmissions([FromQuery] PaginationParams @params, long problemSetId)
    {
        return Ok();
    }
}
