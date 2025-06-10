using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wever_s_miniMarket.ViewModel
{
    public class SupplierVM
    {
        public int SuplidorId { get; set; }
        public string NombreEmpresa { get; set; }
        public string NombreContacto { get; set; }
        public string Telefono { get; set; }
        public string CorreoElectronico { get; set; }
        public string SitioWeb { get; set; }
        public bool ActiveorDeleted { get; set; }
    }
}
