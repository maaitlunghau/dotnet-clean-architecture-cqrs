using CLEAN.CQRS.APPLICATION.DTOs;
using MediatR;

namespace CLEAN.CQRS.APPLICATION.Features.Users.Queries.GetById;

public record GetByIdCommand(Guid Id) : IRequest<UserDto>;
