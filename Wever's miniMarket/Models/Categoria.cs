using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wever_s_miniMarket.Models
{
    public class Categoria
    {
        public int CategoriaId { get; set; }

        public string Nombre { get; set; }

        public string Descripcion { get; set; }

        public string RutaFoto { get; set; }  // Ruta local o URL de la imagen

        public DateTime FechaCreacion { get; set; }

        public DateTime? FechaModificacion { get; set; }

        public bool ActiveorDeleted { get; set; }
    }
}
