using CLEAN.CQRS.APPLICATION.DTOs;
using MediatR;

namespace CLEAN.CQRS.APPLICATION.Features.Users.Queries.GetAllUsers;

public record GetAllUsersQuery() : IRequest<IEnumerable<UserDto>>;