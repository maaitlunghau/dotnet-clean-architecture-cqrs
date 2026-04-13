using AutoMapper;
using CLEAN.CQRS.APPLICATION.DTOs;
using CLEAN.CQRS.APPLICATION.Features.Users.Commands.CreateUser;
using CLEAN.CQRS.APPLICATION.Features.Users.Commands.UpdateUser;
using CLEAN.CQRS.DOMAIN.Entities;

namespace CLEAN.CQRS.APPLICATION.Common.Mapping;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<User, UserDto>();
        CreateMap<CreateUserCommand, User>();
        CreateMap<UpdateUserCommand, User>();
    }
}
