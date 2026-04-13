using CLEAN.CQRS.APPLICATION.Features.Users.Commands.CreateUser;
using CLEAN.CQRS.APPLICATION.Features.Users.Commands.UpdateUser;
using CLEAN.CQRS.APPLICATION.Features.Users.Queries.GetAllUsers;
using CLEAN.CQRS.APPLICATION.Features.Users.Queries.GetById;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CLEAN.CQRS.API.Controllers
{
  [Route("api/v1/[controller]")]
  [ApiController]
  public class UsersController : BaseApiController
  {
    private readonly IMediator _mediator;
    public UsersController(IMediator mediator) => _mediator = mediator;

    [HttpGet]
    public async Task<IActionResult> GetAll()
      => Ok(await _mediator.Send(new GetAllUsersQuery()));

    [HttpGet("{id:guid}")]
    public async Task<IActionResult> GetById(Guid id)
    => Ok(await _mediator.Send(new GetByIdQuery(id)));

    [HttpPost]
    public async Task<IActionResult> Create(CreateUserCommand command)
      => Ok(await _mediator.Send(command));

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(Guid id, UpdateUserCommand command)
    {
      if (id != command.Id) return BadRequest();

      await _mediator.Send(command);
      return NoContent();
    }
  }
}
