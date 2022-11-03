using Microsoft.AspNetCore.Mvc;
using RaqamliAvlod.Infrastructure.Service.Dtos;

namespace RaqamliAvlod.Api.Controllers;

[Route("api/accounts")]
[ApiController]
public class AccountsController : ControllerBase
{
    [HttpPost("registrate")]
    public async Task<IActionResult> RegistrateAsync([FromForm] AccountCreateDto accountCreateViewModel)
        => Ok();

    [HttpPost("login")]
    public async Task<IActionResult> LoginAsync([FromForm] AccountLoginDto accountLoginViewModel)
        => Ok();
}
