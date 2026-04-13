using MediatR;

namespace CLEAN.CQRS.INFRASTRUCTURE.Features.Users.Commands.CreateUser;

public record CreateUserCommand(string Username, string Email) : IRequest<Guid>;
