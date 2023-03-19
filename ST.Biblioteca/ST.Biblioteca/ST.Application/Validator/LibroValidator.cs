using FluentValidation;
using ST.Application.DTOs.Libro.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST.Application.Validator
{
    public class LibroValidator: AbstractValidator<LibroRequestDTo>
    {
        public LibroValidator()
        {
            RuleFor(x => x.Isbn)
                .NotNull().WithMessage("El campo Isbn no puede ser nulo")
                .NotEmpty().WithMessage("El Campo Isbn no puede ser vacio");
        }
    }
}
