﻿using Microsoft.AspNetCore.Mvc;
using SingletonApi.FactoryMethod;
using SingletonApi.Models;

namespace SingletonApi.Controllers;

[ApiController]
[Route("[controller]")]
public class AuthenticationController : ControllerBase
{
    private IAuthenticator _authenticator;

    [HttpPost]
    public IActionResult Authenticate([FromBody] AuthRequestModel request)
    {
        _authenticator = AuthenticatorFactory.CreateAuthenticator(request.AuthType);


        bool isAuthenticated = _authenticator.Authenticate(request.Credentials);

        if (isAuthenticated)
        {
            // Lógica de autenticação bem-sucedida
            return Ok();
        }

        // Lógica de autenticação falhou
        return Unauthorized();
    }

    [HttpGet]
    public IActionResult Get()
    {
        return Ok("Teste");
    }
}
