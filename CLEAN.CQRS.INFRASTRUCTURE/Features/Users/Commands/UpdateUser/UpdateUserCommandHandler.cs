using AutoMapper;
using CLEAN.CQRS.DOMAIN.Interfaces;
using MediatR;

namespace CLEAN.CQRS.INFRASTRUCTURE.Features.Users.Commands.UpdateUser;

public class UpdateUserCommandHandler : IRequestHandler<UpdateUserCommand>
{
    private readonly IUserRepository _userRepository;
    private readonly IMapper _mapper;

    public UpdateUserCommandHandler(IUserRepository userRepository, IMapper mapper)
    {
        _userRepository = userRepository;
        _mapper = mapper;
    }

    public async Task Handle(UpdateUserCommand request, CancellationToken token)
    {
        var user = await _userRepository.GetByIdAsync(request.Id);
        if (user is not null)
        {
            _mapper.Map(request, user);
            await _userRepository.UpdateAsync(user);
        }
    }
}
