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
    public class ProductRepos
    {
        private readonly IConfiguration configuration;

        public ProductRepos(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public IEnumerable<Producto> GetProductos()
        {
            var productlist = new List<Producto>();

            var connectionString = configuration.GetConnectionString("DefaultConnection");
            var connection = new SqlConnection(connectionString);

            connection.Open();

            var command = connection.CreateCommand();
            command.CommandText = @"SELECT ProductoId, Nombre, PrecioUnitario, CategoriaId, SuplidorId, FechaCreacion, FechaModificacion, ActiveorDeleted
            FROM     Productos";

            var dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                var producto = new Producto();
                producto.ProductoId = (int)dataReader["ProductoId"];
                producto.Nombre = (string)dataReader["Nombre"];
                producto.PrecioUnitario = (decimal)dataReader["PrecioUnitario"];
                producto.CategoriaId = (int)dataReader["CategoriaId"];
                producto.SuplidorId = (int)dataReader["SuplidorId"];
                producto.FechaCreacion = dataReader.GetDateTime(5);
                producto.FechaModificacion = dataReader.IsDBNull(6) ? (DateTime?)null : dataReader.GetDateTime(6);
                producto.ActiveorDeleted = (bool)dataReader["ActiveorDeleted"];

                productlist.Add(producto);
            }

            connection.Close();

            return productlist;

        }
        public void AddProducto(Producto producto)
        {
            var connectionString = configuration.GetConnectionString("DefaultConnection");
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = @"INSERT INTO Productos (Nombre, PrecioUnitario, CategoriaId, SuplidorId, FechaCreacion, ActiveorDeleted)
                                 VALUES (@Nombre, @PrecioUnitario, @CategoriaId, @SuplidorId, @FechaCreacion, @ActiveorDeleted)";
                command.Parameters.AddWithValue("@Nombre", producto.Nombre);
                command.Parameters.AddWithValue("@PrecioUnitario", producto.PrecioUnitario);
                command.Parameters.AddWithValue("@CategoriaId", producto.CategoriaId);
                command.Parameters.AddWithValue("@SuplidorId", producto.SuplidorId);
                command.Parameters.AddWithValue("@FechaCreacion", DateTime.Now);
                command.Parameters.AddWithValue("@ActiveorDeleted", true);
                command.ExecuteNonQuery();
            }
        }

        public void UpdateProducto(Producto producto)
        {
            var connectionString = configuration.GetConnectionString("DefaultConnection");
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = @"UPDATE Productos SET Nombre = @Nombre, PrecioUnitario = @PrecioUnitario, 
                                 CategoriaId = @CategoriaId, SuplidorId = @SuplidorId, FechaModificacion = @FechaModificacion
                                 WHERE ProductoId = @ProductoId AND ActiveorDeleted = 1";
                command.Parameters.AddWithValue("@ProductoId", producto.ProductoId);
                command.Parameters.AddWithValue("@Nombre", producto.Nombre);
                command.Parameters.AddWithValue("@PrecioUnitario", producto.PrecioUnitario);
                command.Parameters.AddWithValue("@CategoriaId", producto.CategoriaId);
                command.Parameters.AddWithValue("@SuplidorId", producto.SuplidorId);
                command.Parameters.AddWithValue("@FechaModificacion", DateTime.Now);
                command.ExecuteNonQuery();
            }
        }

        public void DeleteProducto(int productoId)
        {
            var connectionString = configuration.GetConnectionString("DefaultConnection");
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = @"UPDATE Productos SET ActiveorDeleted = 0, FechaModificacion = @FechaModificacion
                                 WHERE ProductoId = @ProductoId";
                command.Parameters.AddWithValue("@ProductoId", productoId);
                command.Parameters.AddWithValue("@FechaModificacion", DateTime.Now);
                command.ExecuteNonQuery();
            }
        }

    }
}
