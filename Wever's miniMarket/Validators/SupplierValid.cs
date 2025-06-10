using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Wever_s_miniMarket.ViewModel;

namespace Wever_s_miniMarket.Validators
{
    public class SupplierValid : AbstractValidator<SupplierVM>
    {
        public SupplierValid() 
        {
            RuleFor(x => x.NombreEmpresa)
               .NotEmpty().WithMessage("El nombre de la empresa es obligatorio.")
               .MaximumLength(150).WithMessage("El nombre de la empresa no puede exceder los 150 caracteres.");

            RuleFor(x => x.NombreContacto)
               .NotEmpty().WithMessage("El nombre del contacto es obligatorio.")
               .MaximumLength(100).WithMessage("El nombre del contacto no puede exceder los 100 caracteres.");

            RuleFor(x => x.Telefono)
               .Matches(@"^\+?\d{10,15}$").WithMessage("El teléfono debe tener un formato válido (10-15 dígitos).")
               .When(x => !string.IsNullOrWhiteSpace(x.Telefono));

            RuleFor(x => x.CorreoElectronico)
                .EmailAddress().WithMessage("El correo electrónico debe tener un formato válido.")
                .When(x => !string.IsNullOrWhiteSpace(x.CorreoElectronico));

            RuleFor(x => x.SitioWeb)
                .MaximumLength(100).WithMessage("El sitio web no puede exceder los 100 caracteres.")
                .Must(BeValidUrl).WithMessage("El sitio web debe tener un formato válido.")
                .When(x => !string.IsNullOrWhiteSpace(x.SitioWeb));

            RuleFor(x => x.ActiveorDeleted)
                .NotNull().WithMessage("El estado de activo/eliminado es obligatorio.");

        }

        private bool BeValidUrl(string url)
        {
            return Regex.IsMatch(url, @"^(https?:\/\/)?([\da-z\.-]+)\.([a-z\.]{2,6})([\/\w \.-]*)*\/?$");
        }
    }
}
