using AutoMapper;
using CLEAN.CQRS.APPLICATION.DTOs;
using CLEAN.CQRS.DOMAIN.Interfaces;
using MediatR;

namespace CLEAN.CQRS.APPLICATION.Features.Users.Queries.GetById;

public class GetByIdQueryHandler : IRequestHandler<GetByIdQuery, UserDto>
{
    private readonly IUserRepository _userRepository;
    private readonly IMapper _mapper;

    public GetByIdQueryHandler(IUserRepository userRepository, IMapper mapper)
    {
        _userRepository = userRepository;
        _mapper = mapper;
    }

    public async Task<UserDto> Handle(GetByIdQuery request, CancellationToken cancellationToken)
    {
        var user = await _userRepository.GetByIdAsync(request.Id);
        return _mapper.Map<UserDto>(user);
    }
}
