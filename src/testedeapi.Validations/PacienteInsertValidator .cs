using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using testedeapi.Api.Abstractions.DTO;

namespace testedeapi.Validations {
    public class PacienteInsertValidator : AbstractValidator<PacienteInsertDTO> {
        static List<string> sexoValid = new List<string> { "F", "M", "O", "P" };

        public PacienteInsertValidator() {            
            RuleFor(a => a.Nome)
                .Length(3, 200).WithMessage("mínimo de 3 e máximo de 200 caractéres")
                .NotNull().WithMessage("Nome é obrigatório");

            RuleFor(a => a.Sexo)
                .MaximumLength(1).WithMessage("Máximo de 1 caracter")
                .Must(a => sexoValid.Contains(a))
                .WithMessage("Deve ser apenas 'F' para Femenino, 'M' para masculino, 'O' para outro e 'P' para Prefiso não declarar")
                .NotNull().WithMessage("Sexo é obrigatório");

            RuleFor(a => a.Nascimento)                
                .InclusiveBetween(DateTime.Parse("1900-01-01"), DateTime.Now)
                .WithMessage("Data de nascimento deve ser maior de 1900 e menor que a data atual")
                .NotNull().WithMessage("Data de nascimento é obrigatório");

            RuleFor(a => a.Inativo);
            RuleFor(a => a.Celular)
                .Length(13, 14).WithMessage("Mínimo de 13 e máximo de 14 caractéres");            
        }
    }
}
