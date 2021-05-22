using Microsoft.AspNetCore.Mvc;
using testedeapi.Business.Abstractions.Interfaces;

namespace testedeapi.Api.Controllers {
    [ApiController]
    [Route("/v1/[controller]")]
    public class TestController : ControllerBase {
        private readonly IPacienteService service;

        public TestController(IPacienteService service) {
            this.service = service;
        }

        [HttpGet]
        [Route("")]
        public string Test(
            ) {            
            return "OK";
        }

    }
}
