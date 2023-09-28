using AutoMapper;
using CleanArchitecture.Domain.Entities;


namespace CleanArchitecture.Application.UseCases.UpdateUser
{
    public sealed class UpdateUserMap : Profile
    {
        public UpdateUserMap() 
        {
            CreateMap<UpdateUserRequest, User>();
            CreateMap<User, UpdateUserResponse>();
        }
    }
}
