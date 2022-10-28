using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RaqamliAvlod.Application.ViewModels.Accounts.Commands;

namespace RaqamliAvlod.Api.Controllers;

[Route("api/accounts")]
[ApiController]
public class AccountsController : ControllerBase
{
    [HttpPost("registrate"), AllowAnonymous]
    public async Task<IActionResult> RegistrateAsync([FromForm] AccountCreateViewModel accountCreateViewModel)
        => Ok();

    [HttpPost("login"), AllowAnonymous]
    public async Task<IActionResult> LoginAsync([FromForm] AccountLoginViewModel accountLoginViewModel)
        => Ok();
}
