using MediatR;

namespace CLEAN.CQRS.APPLICATION.Features.Users.Commands.CreateUser;

public record CreateUserCommand(string Username, string Email) : IRequest<Guid>;
