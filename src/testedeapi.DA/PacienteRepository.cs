using System;
using System.Linq;
using testedeapi.DA.Abstractions.interfaces;
using testedeapi.DA.Abstractions.Models;

namespace testedeapi.DA {
    public class PacienteRepository : IPacienteRepository {
        private readonly testedeapiContext testedeapiContext;

        public PacienteRepository(testedeapiContext context) {
            testedeapiContext = context;
        }

        public IQueryable<paciente> List() {
            return testedeapiContext.paciente;
        }

        public paciente GetById(Guid Idpaciente) {
            var paciente = testedeapiContext.paciente.Where(a => a.Idpaciente == Idpaciente).FirstOrDefault();
            return paciente;
        }

        public void Insert(paciente paciente) {
            testedeapiContext.paciente.Add(paciente);
            testedeapiContext.SaveChanges();
        }

        public void Delete(Guid Idpaciente) {
            var paciente = testedeapiContext.paciente.Where(a => a.Idpaciente == Idpaciente).FirstOrDefault();
            paciente.Inativo = DateTime.Now;
            testedeapiContext.SaveChanges();
        }

        public void Update(Guid Idpaciente, paciente pacienteNew) {
            paciente paciente = testedeapiContext.paciente.Where(a => a.Idpaciente == Idpaciente).FirstOrDefault();

            paciente.Nome = pacienteNew.Nome;
            paciente.Sexo = pacienteNew.Sexo;
            paciente.Nascimento = pacienteNew.Nascimento;
            paciente.Inativo = pacienteNew.Inativo;
            paciente.Celular = pacienteNew.Celular;

            testedeapiContext.SaveChanges();
        }
    }
}
