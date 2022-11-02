using Microsoft.AspNetCore.Mvc;
using RaqamliAvlod.Application.ViewModels.Accounts.Commands;

namespace RaqamliAvlod.Api.Controllers;

[Route("api/accounts")]
[ApiController]
public class AccountsController : ControllerBase
{
    [HttpPost("registrate")]
    public async Task<IActionResult> RegistrateAsync([FromForm] AccountCreateViewModel accountCreateViewModel)
        => Ok();

    [HttpPost("login")]
    public async Task<IActionResult> LoginAsync([FromForm] AccountLoginViewModel accountLoginViewModel)
        => Ok();
}
