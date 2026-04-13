using CLEAN.CQRS.DOMAIN.Entities;
using CLEAN.CQRS.DOMAIN.Interfaces;
using AutoMapper;
using MediatR;

namespace CLEAN.CQRS.INFRASTRUCTURE.Features.Users.Commands.CreateUser;

public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, Guid>
{
    private readonly IUserRepository _userRepository;
    private readonly IMapper _mapper;

    public CreateUserCommandHandler(IUserRepository userRepository, IMapper mapper)
    {
        _userRepository = userRepository;
        _mapper = mapper;
    }

    public async Task<Guid> Handle(CreateUserCommand request, CancellationToken cancellationToken)
    {
        var user = _mapper.Map<User>(request);
        await _userRepository.AddAsync(user);
        return user.Id;
    }
}
