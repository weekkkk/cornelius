﻿using Cornelius.Authorization.Services.Request;
using Cornelius.Authorization.Services.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Cornelius.Authorization.API.Controllers;

public class UserController : ApiBaseController
{
    private readonly IUserService _userService;


    public UserController(IUserService userService)
    {
        ArgumentNullException.ThrowIfNull(userService);

        _userService = userService;
    }

    [HttpPost("Registration")]
    public async Task<IActionResult> Registration([FromBody] RegistrationRequest command,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(command);

        await _userService.RegistrationAsync(command, cancellationToken).ConfigureAwait(false);
        return Ok();
    }

    [HttpPost("Login")]
    public async Task<IActionResult> Login([FromBody] LoginRequest command, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(command);

        var token = await _userService.LoginAsync(command, cancellationToken).ConfigureAwait(false);
        return Ok(token);
    }

    [HttpGet]
    [Authorize]
    public IActionResult Check()
    {
        return Ok();
    }
    [HttpGet("RoleCheck")]
    [Authorize(Roles = "admin")]
    public IActionResult Check2()
    {
        return Ok();
    }
}