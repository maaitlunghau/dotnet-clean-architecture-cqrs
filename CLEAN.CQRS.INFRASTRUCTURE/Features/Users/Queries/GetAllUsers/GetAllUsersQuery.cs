using CLEAN.CQRS.APPLICATION.DTOs;
using MediatR;

namespace CLEAN.CQRS.INFRASTRUCTURE.Features.Users.Queries.GetAllUsers;

public record GetAllUsersQuery() : IRequest<IEnumerable<UserDto>>;