﻿using System;
using System.Collections.Generic;

#nullable disable

namespace testedeapi.DA.Abstractions.Models
{
    public partial class paciente
    {
        public Guid Idpaciente { get; set; }
        public string Nome { get; set; }
        public string Sexo { get; set; }
        public DateTime Nascimento { get; set; }
        public DateTime? Inativo { get; set; }
        public string Celular { get; set; }
    }
}
