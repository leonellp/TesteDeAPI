using AutoMapper;
using AutoMapper.QueryableExtensions;
using System;
using System.Linq;
using testedeapi.Api.Abstractions.DTO;
using testedeapi.Business.Abstractions.DTO;
using testedeapi.Business.Abstractions.Interfaces;
using testedeapi.DA.Abstractions.interfaces;
using testedeapi.DA.Abstractions.Models;

namespace testedeapi.Business {
    public class PacienteService : IPacienteService {
        private readonly IPacienteRepository repository;
        private readonly IMapper mapper;

        public PacienteService(IPacienteRepository repository, IMapper mapper) {
            this.repository = repository;
            this.mapper = mapper;
        }
        public Paginacao<PacienteDTO> List(
            int skip,
            int pageSize,
            bool count,
            bool? inativos = null,
            string pesquisa = null
            ) {
            int? nCount = null;

            var pacientes = repository.List();
            if (inativos == true) {
                pacientes = pacientes.Where(a => a.Inativo != null);
            } else {
                pacientes = pacientes.Where(a => a.Inativo == null);
            }

            if (pesquisa != null) {
                pacientes = pacientes.Where(a => a.Nome.ToUpper().Contains(pesquisa.ToUpper()));
            }

            if (count) {
                nCount = pacientes.Count();
            }

            if (skip < 0) skip = 0;
            pacientes = pacientes.OrderBy(a => a.Nome);
            pacientes = pacientes.Skip(skip).Take(pageSize);

            return new Paginacao<PacienteDTO>() {
                Values = pacientes.ProjectTo<PacienteDTO>(mapper.ConfigurationProvider).ToArray(),
                Count = nCount
            };
        }
        public PacienteDTO GetById(Guid Idpaciente) {
            return mapper.Map<PacienteDTO>(repository.GetById(Idpaciente));
        }
        public void Insert(PacienteInsertDTO paciente) {
            var _paciente = mapper.Map<paciente>(paciente);
            _paciente.Idpaciente = Guid.NewGuid();
            repository.Insert(_paciente);
        }

        public void Delete(Guid Idpaciente) {
            repository.Delete(Idpaciente);
        }

        public void Update(Guid Idpaciente, PacienteDTO pacienteNew) {
            var _pacienteNew = mapper.Map<paciente>(pacienteNew);
            repository.Update(Idpaciente, _pacienteNew);
        }
    }
}
