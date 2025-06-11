using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wever_s_miniMarket.Models;

namespace Wever_s_miniMarket.Repository
{
    public class SupplierRepos
    {
        private readonly IConfiguration configuration;

        public SupplierRepos(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        public IEnumerable<Suplidor> GetSuplidores()
        {
            var supplierlist = new List<Suplidor>();

            var connectionString = configuration.GetConnectionString("DefaultConnection");
            var connection = new SqlConnection(connectionString);

            connection.Open();

            var command = connection.CreateCommand();
            command.CommandText = @" SELECT SuplidorId, NombreEmpresa, NombreContacto, Telefono, CorreoElectronico, SitioWeb, FechaCreacion, FechaModificacion, ActiveorDeleted
            FROM     Suplidores";

            var dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                var suplidor = new Suplidor();
                suplidor.SuplidorId = (int)dataReader["SuplidorId"];
                suplidor.NombreEmpresa = (string)dataReader["NombreEmpresa"];
                suplidor.NombreContacto = (string)dataReader["NombreContacto"];
                suplidor.Telefono = (string)dataReader["Telefono"];
                suplidor.CorreoElectronico = (string)dataReader["CorreoElectronico"];
                suplidor.SitioWeb = (string)dataReader["SitioWeb"];
                suplidor.FechaCreacion = dataReader.GetDateTime(6);
                suplidor.FechaModificacion = dataReader.IsDBNull(7) ? (DateTime?)null : dataReader.GetDateTime(7);
                suplidor.ActiveorDeleted = (bool)dataReader["ActiveorDeleted"];

                supplierlist.Add(suplidor);
            }

            connection.Close();

            return supplierlist;

        }

    }
}
