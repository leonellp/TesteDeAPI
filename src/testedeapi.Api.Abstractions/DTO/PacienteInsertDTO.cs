using System;

namespace testedeapi.Api.Abstractions.DTO {
    public partial class PacienteInsertDTO {        
        public string Nome { get; set; }
        public string Sexo { get; set; }
        public DateTime Nascimento { get; set; }
        public DateTime? Inativo { get; set; }
        public string Celular { get; set; }
    }
}
