using System;
using System.Linq;
using testedeapi.DA.Abstractions.Models;

namespace testedeapi.DA.Abstractions.interfaces {
    public interface IPacienteRepository {
        IQueryable<paciente> List();
        paciente GetById(Guid Idpaciente);
        void Insert(paciente paciente);
        void Delete(Guid Idpaciente);
        void Update(Guid Idpaciente, paciente pacienteNew);
    }
}
