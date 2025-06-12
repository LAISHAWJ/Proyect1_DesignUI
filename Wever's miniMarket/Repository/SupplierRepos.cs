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

        public void AddSuplidor(Suplidor suplidor)
        {
            var connectionString = configuration.GetConnectionString("DefaultConnection");
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = @"INSERT INTO Suplidores (NombreEmpresa, NombreContacto, Telefono, CorreoElectronico, SitioWeb, FechaCreacion, ActiveorDeleted)
                                 VALUES (@NombreEmpresa, @NombreContacto, @Telefono, @CorreoElectronico, @SitioWeb, @FechaCreacion, @ActiveorDeleted)";
                command.Parameters.AddWithValue("@NombreEmpresa", suplidor.NombreEmpresa);
                command.Parameters.AddWithValue("@NombreContacto", (object)suplidor.NombreContacto ?? DBNull.Value);
                command.Parameters.AddWithValue("@Telefono", (object)suplidor.Telefono ?? DBNull.Value);
                command.Parameters.AddWithValue("@CorreoElectronico", (object)suplidor.CorreoElectronico ?? DBNull.Value);
                command.Parameters.AddWithValue("@SitioWeb", (object)suplidor.SitioWeb ?? DBNull.Value);
                command.Parameters.AddWithValue("@FechaCreacion", DateTime.Now);
                command.Parameters.AddWithValue("@ActiveorDeleted", true);
                command.ExecuteNonQuery();
            }
        }


        public void UpdateSuplidor(Suplidor suplidor)
        {
            var connectionString = configuration.GetConnectionString("DefaultConnection");
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = @"UPDATE Suplidores SET NombreEmpresa = @NombreEmpresa, NombreContacto = @NombreContacto, 
                                 Telefono = @Telefono, CorreoElectronico = @CorreoElectronico, SitioWeb = @SitioWeb, 
                                 FechaModificacion = @FechaModificacion
                                 WHERE SuplidorId = @SuplidorId AND ActiveorDeleted = 1";
                command.Parameters.AddWithValue("@SuplidorId", suplidor.SuplidorId);
                command.Parameters.AddWithValue("@NombreEmpresa", suplidor.NombreEmpresa);
                command.Parameters.AddWithValue("@NombreContacto", (object)suplidor.NombreContacto ?? DBNull.Value);
                command.Parameters.AddWithValue("@Telefono", (object)suplidor.Telefono ?? DBNull.Value);
                command.Parameters.AddWithValue("@CorreoElectronico", (object)suplidor.CorreoElectronico ?? DBNull.Value);
                command.Parameters.AddWithValue("@SitioWeb", (object)suplidor.SitioWeb ?? DBNull.Value);
                command.Parameters.AddWithValue("@FechaModificacion", DateTime.Now);
                command.ExecuteNonQuery();
            }
        }

        public void DeleteSuplidor(int suplidorId)
        {
            var connectionString = configuration.GetConnectionString("DefaultConnection");
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = @"UPDATE Suplidores SET ActiveorDeleted = 0, FechaModificacion = @FechaModificacion
                                 WHERE SuplidorId = @SuplidorId";
                command.Parameters.AddWithValue("@SuplidorId", suplidorId);
                command.Parameters.AddWithValue("@FechaModificacion", DateTime.Now);
                command.ExecuteNonQuery();
            }
        }

    }
}
