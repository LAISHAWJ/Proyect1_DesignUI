using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wever_s_miniMarket.Models
{
    internal class Producto
    {
        public int ProductoId { get; set; }

        public string Nombre { get; set; }

        public decimal PrecioUnitario { get; set; }

        public int CategoriaId { get; set; }

        public int SuplidorId { get; set; }

        public DateTime FechaCreacion { get; set; }

        public DateTime? FechaModificacion { get; set; }

        public bool ActiveorDeleted { get; set; }

    }
}
