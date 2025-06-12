using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wever_s_miniMarket.ViewModel;

namespace Wever_s_miniMarket.Validators
{
    public class ProductValid : AbstractValidator<ProductVM>
    {
        public ProductValid() 
        {
            RuleFor(x => x.Nombre)
                .NotEmpty().WithMessage("El nombre es obligatorio.")
                .MaximumLength(150).WithMessage("El nombre no puede exceder los 150 caracteres.");

            RuleFor(x => x.PrecioUnitario)
                .NotEmpty().WithMessage("El precio es obligatorio.")
                .GreaterThan(0).WithMessage("El precio unitario debe ser mayor que cero.")
                .LessThanOrEqualTo(1000000).WithMessage("El precio unitario no puede exceder 1,000,000.");

            RuleFor(x => x.CategoriaId)
              .GreaterThan(0).WithMessage("Debe seleccionar una categoría válida.");

            RuleFor(x => x.SuplidorId)
               .GreaterThan(0).WithMessage("Debe seleccionar un suplidor válido.");

            RuleFor(x => x.ActiveorDeleted)
                          .NotNull().WithMessage("El estado de activo/eliminado es obligatorio.");
        }
    }
}
