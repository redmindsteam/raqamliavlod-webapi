using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RaqamliAvlod.Infrastructure.Service.Dtos;
using RaqamliAvlod.Infrastructure.Service.Interfaces.Users;

namespace RaqamliAvlod.Api.Controllers;

[Route("api/accounts")]
[ApiController]
public class AccountsController : ControllerBase
{
    private readonly IAccountService _accountService;
    public AccountsController(IAccountService accountService)
    {
        _accountService = accountService;
    }

    [HttpPost("register"), AllowAnonymous]
    public async Task<IActionResult> RegistrateAsync([FromForm] AccountCreateDto accountCreateViewModel)
        => Ok(await _accountService.RegisterAsync(accountCreateViewModel));

    [HttpPost("login")]
    public async Task<IActionResult> LoginAsync([FromForm] AccountLoginDto accountLoginViewModel)
        => Ok(await _accountService.LogInAsync(accountLoginViewModel));

    [HttpPost("verifyemail")]
    public async Task<IActionResult> VerifyEmail([FromBody] VerifyEmailDto verifyEmail)
        => Ok(await _accountService.VerifyEmailAsync(verifyEmail));

    [HttpPost("reset-password")]
    public async Task<IActionResult> ForgotPasswordAsync([FromQuery] UserResetPasswordDto userReset)
        => Ok(await _accountService.VerifyPasswordAsync(userReset));

    [HttpPost("sendcode")]
    public async Task<IActionResult> SendToEmail([FromBody] SendToEmailDto sendTo)
    {
        await _accountService.SendCodeAsync(sendTo);
        
        return Ok();
    }
}
