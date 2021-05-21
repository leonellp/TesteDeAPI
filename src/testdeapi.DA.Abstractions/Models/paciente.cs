using System;
using System.Collections.Generic;

#nullable disable

namespace testedeapi.DA.Abstractions.Models
{
    public partial class paciente
    {
        public Guid idpaciente { get; set; }
        public string nome { get; set; }
        public string sexo { get; set; }
        public DateTime nascimento { get; set; }
        public DateTime? inativo { get; set; }
        public string celular { get; set; }
    }
}
