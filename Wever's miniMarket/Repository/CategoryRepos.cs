using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wever_s_miniMarket.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Wever_s_miniMarket.Repository
{
    public class CategoryRepos
    {
        private readonly IConfiguration configuration;

        public CategoryRepos(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public IEnumerable<Categoria> GetCategorias()
        {
            var categorylist = new List<Categoria>();

            var connectionString = configuration.GetConnectionString("DefaultConnection");
            var connection = new SqlConnection(connectionString);

            connection.Open();

            var command = connection.CreateCommand();
            command.CommandText = @"SELECT CategoriaId, Nombre, Descripcion, RutaFoto, FechaCreacion, FechaModificacion, ActiveorDeleted
            FROM     Categorias";



            var dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                var categoria = new Categoria();
                categoria.CategoriaId = (int)dataReader["CategoriaId"];
                categoria.Nombre = (string)dataReader["Nombre"];
                categoria.Descripcion = (string)dataReader["Descripcion"];
                categoria.RutaFoto = dataReader["RutaFoto"] as string;
                categoria.FechaCreacion = dataReader.GetDateTime(4);
                categoria.FechaModificacion = dataReader.IsDBNull(5) ? (DateTime?)null : dataReader.GetDateTime(5);
                categoria.ActiveorDeleted = (bool)dataReader["ActiveorDeleted"];

                categorylist.Add(categoria);
            }

            connection.Close();

            return categorylist;
        }

        public void AddCategoria(Categoria categoria)
        {
            var connectionString = configuration.GetConnectionString("DefaultConnection");
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = @"INSERT INTO Categorias (Nombre, Descripcion, RutaFoto, FechaCreacion, ActiveorDeleted)
                                 VALUES (@Nombre, @Descripcion, @RutaFoto, @FechaCreacion, @ActiveorDeleted)";
                command.Parameters.AddWithValue("@Nombre", categoria.Nombre);
                command.Parameters.AddWithValue("@Descripcion", (object)categoria.Descripcion ?? DBNull.Value);
                command.Parameters.AddWithValue("@RutaFoto", (object)categoria.RutaFoto ?? DBNull.Value);
                command.Parameters.AddWithValue("@FechaCreacion", DateTime.Now);
                command.Parameters.AddWithValue("@ActiveorDeleted", true);
                command.ExecuteNonQuery();
            }
        }

        public void UpdateCategoria(Categoria categoria)
        {
            var connectionString = configuration.GetConnectionString("DefaultConnection");
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = @"UPDATE Categorias SET Nombre = @Nombre, Descripcion = @Descripcion, 
                                 RutaFoto = @RutaFoto, FechaModificacion = @FechaModificacion, ActiveorDeleted = 1
                                 WHERE CategoriaId = @CategoriaId"; 
                command.Parameters.AddWithValue("@CategoriaId", categoria.CategoriaId);
                command.Parameters.AddWithValue("@Nombre", categoria.Nombre);
                command.Parameters.AddWithValue("@Descripcion", (object)categoria.Descripcion ?? DBNull.Value);
                command.Parameters.AddWithValue("@RutaFoto", (object)categoria.RutaFoto ?? DBNull.Value);
                command.Parameters.AddWithValue("@FechaModificacion", DateTime.Now);
                command.Parameters.AddWithValue("@ActiveorDeleted", true);
                command.ExecuteNonQuery();

            }
        }

        public void DeleteCategoria(int categoriaId)
        {
            var connectionString = configuration.GetConnectionString("DefaultConnection");
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = @"UPDATE Categorias SET ActiveorDeleted = 0, FechaModificacion = @FechaModificacion
                                 WHERE CategoriaId = @CategoriaId";
                command.Parameters.AddWithValue("@CategoriaId", categoriaId);
                command.Parameters.AddWithValue("@FechaModificacion", DateTime.Now);
                command.ExecuteNonQuery();
            }
        }

    }
}
