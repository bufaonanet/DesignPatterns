using AwesomeShopDesignPatterns.Application;
using AwesomeShopDesignPatterns.Application.NotifyUser;
using Microsoft.AspNetCore.Mvc;

namespace AwesomeShopDesignPatterns.Controllers;

[Route("api/[controller]")]
[ApiController]
public class NotificationsController : ControllerBase
{
    private readonly IMediator _mediator;

    public NotificationsController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<IActionResult> Notify(NotifyUserCommand command)
    {
        await _mediator.Send(command);

        return Accepted();
    }
}