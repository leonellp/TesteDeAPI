using Microsoft.AspNetCore.Mvc;
using testedeapi.Business.Abstractions.Interfaces;

namespace testedeapi.Api.Controllers {
    [ApiController]
    [Route("/v1/[controller]")]
    public class HealthController : ControllerBase {
        private readonly IPacienteService service;

        public HealthController(IPacienteService service) {
            this.service = service;
        }

        /// <summary>
        /// Testar se a API está funcionando
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("")]
        
        public string Health(
            ) {            
            return "OK";
        }        
    }
}
