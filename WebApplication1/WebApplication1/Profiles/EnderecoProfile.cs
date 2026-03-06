using AutoMapper;
using WebApplication1.DTOs;
using WebApplication1.Models;

namespace WebApplication1.Profiles;

public class EnderecoProfile : Profile
{
  public EnderecoProfile()
  {
    CreateMap<CreateEnderecoDto, Endereco>();
    CreateMap<Endereco, ReadEnderecoDto>();
    CreateMap<UpdateEnderecoDto, Endereco>();
  }   
}