using AutoMapper;
using TesteArq.Application.DTOs;
using TesteArq.Application.DTOs.HorasComplementares;
using TesteArq.Domain.Entity;

namespace TesteArq.Application.Mappings
{
    public class DtoMappingProfile : Profile
    {
        public DtoMappingProfile()
        {
            CreateMap<Aluno,AlunoDTO>().ReverseMap();
            CreateMap<Curso,CursoDTO>().ReverseMap();
            CreateMap<HorasComplementares,HorasComplementaresDTO>().ReverseMap();
            CreateMap<HorasComplementares,CreateHorasComplementaresDTO>().ReverseMap();
        }
    }
}
