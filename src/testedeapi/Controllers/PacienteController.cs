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


        /// <summary>
        /// Lista pacientes
        /// </summary>
        /// <param name="skip"> Quantidade de pacientes que deseja pular para paginação</param>
        /// <param name="pageSize"> Quantidade de paciente que deseja listar</param>
        /// <param name="count">    Quatidade de pacientes no banco para calcular a quantidade de páginas</param>
        /// <param name="inativos"> Pacientes inativados</param>
        /// <param name="pesquisa"> Pesquisa de acordo com o nome</param>
        /// <returns></returns>
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

        /// <summary>
        /// Trazer o paciente de acordo com o Id dele
        /// </summary>
        /// <param name="Idpaciente">   Id do paciente</param>
        /// <returns></returns>
        [HttpGet]
        [Route("{Idpaciente}")]
        public PacienteDTO Get(Guid Idpaciente) {
            return service.GetById(Idpaciente);
        }

        /// <summary>
        /// Inserir paciente
        /// </summary>
        /// <param name="paciente">Informações do paciente:
        /// 
        /// Validações:
        ///     Nome: É obrigatório e precisa ter entre 3 e 200 caracteres;
        ///     Sexo: É obrigatório e precisa ser inserido apenas "M"(Masculino), "F"(Feminino), "O" (Outro), "P" (Prefiro não declarar);
        ///     Nascimento: É obrigatório e precisa ser uma data entre 1900/01/01 e a data atual;
        ///     Inativo: Caso queira deixar o paciente inativo inserir a data que foi inativado;
        ///     Celular: Não é obrigatório e pode ser inserido no mínimo 13 caracteres ((11)1111-1111) e máximo de 14 ((11)91111-1111);
        /// </param>
        [HttpPost]
        public void Insert(PacienteInsertDTO paciente) {            
            service.Insert(paciente);
        }

        /// <summary>
        /// Inativar o paciente
        /// </summary>
        /// <param name="Idpaciente">Id do paciente a ser inativado</param>
        [HttpDelete]
        [Route("{Idpaciente}")]
        public void Delete(Guid Idpaciente) {
            service.Delete(Idpaciente);
        }

        /// <summary>
        /// Atualizar um paciente
        /// </summary>
        /// <param name="Idpaciente">Id o paciente a ser atualizado
        ///     *É obrigatório
        /// </param>
        /// <param name="paciente">Informações do paciente atualizada:        
        ///         
        /// Validações:
        ///     Nome: É obrigatório e precisa ter entre 3 e 200 caracteres;
        ///     Sexo: É obrigatório e precisa ser inserido apenas "M"(Masculino), "F"(Feminino), "O" (Outro), "P" (Prefiro não declarar);
        ///     Nascimento: É obrigatório e precisa ser uma data entre 1900/01/01 e a data atual;
        ///     Inativo: Caso queira deixar o paciente inativo inserir a data que foi inativado;
        ///     Celular: Não é obrigatório e pode ser inserido no mínimo 13 caracteres ((11)1111-1111) e máximo de 14 ((11)91111-1111);
        /// </param>
        [HttpPut]
        [Route("{Idpaciente}")]
        public void Update(Guid Idpaciente, PacienteDTO paciente) {
            service.Update(Idpaciente, paciente);
        }
    }
}
