using AutoMapper;
using TesteArq.Application.DTOs;
using TesteArq.Application.DTOs.AtividadesDTO;
using TesteArq.Application.DTOs.GrupoAtividadesDTO;
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
            CreateMap<Atividades,AtividadesDTO>().ReverseMap();
            CreateMap<Atividades,CreateAtividadesDTO>().ReverseMap();
            CreateMap<Atividades,UpdateAtividadesDTO>().ReverseMap();
            CreateMap<GrupoAtividades,CreateGrupoAtividadesDTO>().ReverseMap();
            CreateMap<GrupoAtividades,GrupoAtividadesDTO>().ReverseMap();
            CreateMap<Area,AreaDTO>().ReverseMap();
        }
    }
}
