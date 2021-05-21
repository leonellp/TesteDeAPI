using System;
using testedeapi.Api.Abstractions.DTO;
using testedeapi.Business.Abstractions.DTO;

namespace testedeapi.Business.Abstractions.Interfaces {
    public interface IPacienteService {
        Paginacao<PacienteDTO> List(
            int skip,
            int pageSize,
            bool count,
            bool? inativos = null,
            string pesquisa = null
            );
        PacienteDTO GetById(Guid Idpaciente);
        void Insert(PacienteInsertDTO paciente);
        void Delete(Guid Idpaciente);
        void Update(Guid Idpaciente, PacienteDTO pacienteNew);
    }
}
