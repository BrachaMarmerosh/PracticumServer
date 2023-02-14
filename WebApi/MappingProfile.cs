using AutoMapper;
using Common.DTOs;
using Repositories.Entities;
using WebApi.Models;

namespace WebApi
{
  public class MappingProfile : Profile
  {
    public MappingProfile()
    {
        CreateMap<UserModel, UserDTO>().ReverseMap();

    }
  }
}
