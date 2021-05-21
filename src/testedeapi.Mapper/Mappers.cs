using AutoMapper;
using testedeapi.Api.Abstractions.DTO;
using testedeapi.DA.Abstractions.Models;

namespace testedeapi.Mapper {
    public class Mappers : Profile {
        public Mappers() {
            CreateMap<PacienteDTO, paciente>().ReverseMap();
            CreateMap<PacienteInsertDTO, paciente>().ReverseMap();
        }
    }
}
