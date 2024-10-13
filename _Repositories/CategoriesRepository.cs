using Microsoft.Data.SqlClient;
using Supermarket_mvp.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp._Repositories
{
    internal class CategoriesRepository : BaseRepository, ICategoriesRepository
    {
        public CategoriesRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public void Add(CategoriesModel categoriesModel)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Edit(CategoriesModel categoriesModel)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CategoriesModel> GetAll()
        {
            var categoriesList = new List<CategoriesModel>();
            using (var connetion = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connetion.Open();
                command.Connection = connetion;
                command.CommandText = "SELECT * FROM Categories ORDER BY categories_Id DESC";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var categoriesModel = new CategoriesModel();
                        categoriesModel.Id = (int)reader["categories_Id"];
                        categoriesModel.Name = reader["Categories_Name"].ToString();
                        categoriesModel.Description = reader["Categories_Description"].ToString();
                        categoriesList.Add(categoriesModel);
                    }

                }
            }
            return categoriesList;
        }

        public IEnumerable<CategoriesModel> GetByValue(string value)
        {
            var categoriesList = new List<CategoriesModel>();
            int categoriesId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string categoriesName = value;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"SELECT * FROM Categories
                                       WHERE categories_Id=@id or Categories_Name LIKE @name+ '%'
                                       ORDER By categories_Id DESC";
                command.Parameters.Add("@id", SqlDbType.Int).Value = categoriesId;
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = categoriesName;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var categoriesModel = new CategoriesModel();
                        categoriesModel.Id = (int)reader["categories_Id"];
                        categoriesModel.Name = reader["Categories_Name"].ToString();
                        categoriesModel.Description = reader["Categories_Description"].ToString();
                        categoriesList.Add(categoriesModel);
                    }
                }
            }
            return categoriesList;
        }
    }
}
