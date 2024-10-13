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
    internal class CustomersRepository : BaseRepository, ICustomersRepository
    {
        public CustomersRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public void Add(CustomersModel customersModel)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Edit(CustomersModel customersModel)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CustomersModel> GetAll()
        {
            var customersList = new List<CustomersModel>();
            using (var connetion = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connetion.Open();
                command.Connection = connetion;
                command.CommandText = "SELECT * FROM Customers ORDER BY Customers_ID DESC";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var customersModel = new CustomersModel();
                        customersModel.Id = (int)reader["Customers_Id"];
                        customersModel.Document = (int)reader["Customers_Document"];
                        customersModel.FirstName = reader["Customers_First_Name"].ToString();
                        customersModel.LastName = reader["Customers_Last_Name"].ToString();
                        customersModel.Address = reader["Customers_Address"].ToString();
                        customersModel.Birthday = reader["Customers_Birthday"].ToString();
                        customersModel.PhoneNumber = reader["Customers_Phone_Number"].ToString();
                        customersModel.Email = reader["Customers_Email"].ToString();
                        customersList.Add(customersModel);
                    }

                }
            }
            return customersList;
        }

        public IEnumerable<CustomersModel> GetByValue(string value)
        {

            var customersList = new List<CustomersModel>();
            int customersId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string customersDocument = value;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"SELECT * FROM Customers
                                       WHERE Customers_Id=@id or Customers_Document LIKE @name+ '%'
                                       ORDER By Customers_Id DESC";
                command.Parameters.Add("@id", SqlDbType.Int).Value = customersId;
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = customersDocument;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var customersModel = new CustomersModel();
                        customersModel.Id = (int)reader["Customers_Id"];
                        customersModel.Document = (int)reader["Customers_Document"];
                        customersModel.FirstName = reader["Customers_First_Name"].ToString();
                        customersModel.LastName = reader["Customers_Last_Name"].ToString();
                        customersModel.Address = reader["Customers_Address"].ToString();
                        customersModel.Birthday = reader["Customers_Birthday"].ToString();
                        customersModel.PhoneNumber = reader["Customers_Phone_Number"].ToString();
                        customersModel.Email = reader["Customers_Email"].ToString();
                        customersList.Add(customersModel);
                    }
                }
            }
            return customersList;
        }
    }
}
