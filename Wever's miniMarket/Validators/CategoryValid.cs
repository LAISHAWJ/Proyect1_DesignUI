using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wever_s_miniMarket.ViewModel;

namespace Wever_s_miniMarket.Validators
{
    public class CategoryValid: AbstractValidator <CategoryVM>
    {
        public CategoryValid() 
        {
            RuleFor(x => x.Nombre)
                  .NotEmpty().WithMessage("El nombre es obligatorio.")
                  .MaximumLength(100).WithMessage("El nombre no puede exceder los 100 caracteres.");

            RuleFor(x => x.Descripcion)
                .MaximumLength(500).WithMessage("La descripción no puede exceder los 500 caracteres.")
                .When(x => !string.IsNullOrEmpty(x.Descripcion));

            RuleFor(x => x.ActiveorDeleted)
              .NotNull().WithMessage("El estado de activo/eliminado es obligatorio.");
        }

    }
}
