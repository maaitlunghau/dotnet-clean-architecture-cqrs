using MediatR;

namespace CLEAN.CQRS.INFRASTRUCTURE.Features.Users.Commands.UpdateUser;

public record UpdateUserCommand(Guid Id, string Username, string Email) : IRequest;
