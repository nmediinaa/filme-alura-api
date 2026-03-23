using AutoMapper;
using WebApplication1.DTOs;
using WebApplication1.Models;

namespace WebApplication1.Profiles;

public class FilmeProfile : Profile
{
    public FilmeProfile()
    {
        CreateMap<CreateFilmeDto, Filme>();
        CreateMap<UpdateFilmeDto, Filme>();
        CreateMap<Filme, UpdateFilmeDto>();
        CreateMap<Filme, ReadFilmeDto>()
            .ForMember(dto => dto.sessoes,//Aqui estamos mapeando para o membro ReadCinemaDto,
            //um ReadEnderecoDto
            opt => 
                opt.MapFrom(cinema => cinema.Sessoes));
    }
}