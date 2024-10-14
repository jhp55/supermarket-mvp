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
    internal class ProductsRepository : BaseRepository, IProductsRepository
    {
        public ProductsRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public void Add(ProductsModel productsModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "INSERT INTO Products VALUES (@Products_Name, @Products_Price, @Products_Stock, @Products_Category_Id)";
                command.Parameters.Add("@Products_Name", SqlDbType.NVarChar).Value = productsModel.Name;
                command.Parameters.Add("@Products_Price", SqlDbType.Int).Value = productsModel.Price;
                command.Parameters.Add("@Products_Stock", SqlDbType.Int).Value = productsModel.Stock;
                command.Parameters.Add("@Products_Category_Id", SqlDbType.Int).Value = productsModel.Id_Categories;
                command.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "DELETE FROM Products WHERE Products_Id = @id";
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                command.ExecuteNonQuery();

            }
        }

        public void Edit(ProductsModel productsModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"UPDATE Products
                                      SET Products_Name =@Products_Name,
                                      Products_Price = @Products_Price,
                                      Products_Stock = @Products_Stock,
                                      Products_Category_Id = @Products_Category_Id
                                      WHERE Products_Id = @Products_Id";
                command.Parameters.Add("@Products_Name", SqlDbType.NVarChar).Value = productsModel.Name;
                command.Parameters.Add("@Products_Price", SqlDbType.Int).Value = productsModel.Price;
                command.Parameters.Add("@Products_Stock", SqlDbType.Int).Value = productsModel.Stock;
                command.Parameters.Add("@Products_Category_Id", SqlDbType.Int).Value = productsModel.Id_Categories;
                command.Parameters.Add("@Products_Id", SqlDbType.Int).Value = productsModel.Id;
                command.ExecuteNonQuery();

            }
        }

        public IEnumerable<ProductsModel> GetAll()
        {
            var productsList = new List<ProductsModel>();
            using (var connetion = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connetion.Open();
                command.Connection = connetion;
                command.CommandText = "SELECT * FROM Products ORDER BY Products_Id DESC";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var productsModel = new ProductsModel();
                        productsModel.Id = (int)reader["Products_Id"];
                        productsModel.Name = reader["Products_Name"].ToString();
                        productsModel.Price = (int)reader["Products_Price"];
                        productsModel.Stock = (int)reader["Products_Stock"];
                        productsModel.Id_Categories = (int)reader["Products_Category_Id"];
                        productsList.Add(productsModel);
                    }

                }
            }
            return productsList;
        }

        public IEnumerable<ProductsModel> GetByValue(string value)
        {
            var productsList = new List<ProductsModel>();
            int productsId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string productsName = value;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"SELECT * FROM Products
                                       WHERE Products_Id=@id or Products_Name LIKE @name+ '%'
                                       ORDER By Products_Id DESC";
                command.Parameters.Add("@id", SqlDbType.Int).Value = productsId;
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = productsName;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var productsModel = new ProductsModel();
                        productsModel.Id = (int)reader["Products_Id"];
                        productsModel.Name = reader["Products_Name"].ToString();
                        productsModel.Price = (int)reader["Products_Price"];
                        productsModel.Stock = (int)reader["Products_Stock"];
                        productsModel.Id_Categories = (int)reader["Products_Category_Id"];
                        productsList.Add(productsModel);
                    }
                }
            }
            return productsList;
        }
    }
}
