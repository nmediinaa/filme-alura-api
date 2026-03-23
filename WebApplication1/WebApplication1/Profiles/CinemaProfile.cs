using AutoMapper;
using WebApplication1.DTOs;
using WebApplication1.Models;

namespace WebApplication1.Profiles;

public class CinemaProfile : Profile
{
    public CinemaProfile()
    {
        CreateMap<CreateCinemaDto, Cinema>();
        CreateMap<UpdateCinemaDto, Cinema>();
        CreateMap<Cinema, ReadCinemaDto>()
            .ForMember(dto => dto.Endereco,//Aqui estamos mapeando para o membro ReadCinemaDto,
                                                  //um ReadEnderecoDto
                opt => 
                    opt.MapFrom(cinema => cinema.Endereco))
            .ForMember(dto => dto.sessoes,//Aqui estamos mapeando para o membro ReadCinemaDto,
            //um ReadEnderecoDto
            opt => 
                opt.MapFrom(cinema => cinema.sessoes));
    }
}