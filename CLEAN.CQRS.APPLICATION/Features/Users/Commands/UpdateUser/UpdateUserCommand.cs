using MediatR;

namespace CLEAN.CQRS.APPLICATION.Features.Users.Commands.UpdateUser;

public record UpdateUserCommand(Guid Id, string Username, string Email) : IRequest;
