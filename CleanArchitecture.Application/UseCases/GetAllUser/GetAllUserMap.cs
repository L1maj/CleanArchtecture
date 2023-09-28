using AutoMapper;
using CleanArchitecture.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.UseCases.GetAllUser
{
    public sealed class GetAllUserMap : Profile
    {
        public GetAllUserMap() 
        {            
            CreateMap<User, GetAllUserResponse>();
        }
    }
}
