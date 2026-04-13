using AutoMapper;
using CLEAN.CQRS.APPLICATION.DTOs;
using CLEAN.CQRS.DOMAIN.Interfaces;
using MediatR;

namespace CLEAN.CQRS.INFRASTRUCTURE.Features.Users.Queries.GetById;

public class GetByIdCommandHandler : IRequestHandler<GetByIdCommand, UserDto>
{
    private readonly IUserRepository _userRepository;
    private readonly IMapper _mapper;

    public GetByIdCommandHandler(IUserRepository userRepository, IMapper mapper)
    {
        _userRepository = userRepository;
        _mapper = mapper;
    }

    public async Task<UserDto> Handle(GetByIdCommand request, CancellationToken cancellationToken)
    {
        var user = await _userRepository.GetByIdAsync(request.Id);
        return _mapper.Map<UserDto>(user);
    }
}
