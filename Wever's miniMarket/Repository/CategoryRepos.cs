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
            command.CommandText = @"
            SELECT CategoriaId, Nombre, Descripcion, FechaCreacion, FechaModificacion, ActiveorDeleted
            FROM     Categorias";


            var dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                var categoria = new Categoria();
                categoria.CategoriaId = (int)dataReader["CategoriaId"];
                categoria.Nombre = (string)dataReader["Nombre"];
                categoria.Descripcion = (string)dataReader["Descripcion"];
                categoria.FechaCreacion = dataReader.GetDateTime(3);
                categoria.FechaModificacion = dataReader.IsDBNull(4) ? (DateTime?)null : dataReader.GetDateTime(4);
                categoria.ActiveorDeleted = (bool)dataReader["ActiveorDeleted"];

                categorylist.Add(categoria);
            }

            connection.Close();

            return categorylist;
        }

     
    }
}
