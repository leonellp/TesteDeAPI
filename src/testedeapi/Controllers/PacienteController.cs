using Microsoft.AspNetCore.Mvc;
using System;
using testedeapi.Api.Abstractions.DTO;
using testedeapi.Business.Abstractions.DTO;
using testedeapi.Business.Abstractions.Interfaces;

namespace testedeapi.Api.Controllers {
    [ApiController]
    [Route("/v1/[controller]")]
    public class PacienteController : ControllerBase {
        private readonly IPacienteService service;

        public PacienteController(IPacienteService service) {
            this.service = service;
        }

        [HttpGet]
        [Route("")]
        public Paginacao<PacienteDTO> List(
            int skip = 0,
            int pageSize = 5,
            bool count = false,
            bool? inativos = false,
            string pesquisa = null
            ) {            
            return service.List(skip, pageSize, count, inativos, pesquisa);
        }

        [HttpGet]
        [Route("{Idpaciente}")]
        public PacienteDTO Get(Guid Idpaciente) {
            return service.GetById(Idpaciente);
        }

        [HttpPost]
        public void Insert(PacienteInsertDTO paciente) {            
            service.Insert(paciente);
        }

        [HttpDelete]
        [Route("{Idpaciente}")]
        public void Delete(Guid Idpaciente) {
            service.Delete(Idpaciente);
        }

        [HttpPut]
        [Route("{Idpaciente}")]
        public void Update(Guid Idpaciente, PacienteDTO paciente) {
            service.Update(Idpaciente, paciente);
        }
    }
}
