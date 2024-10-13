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
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "INSERT INTO Customers VALUES (@Customers_Document, @Customers_First_Name, @Customers_Last_Name, @Customers_Address, @Customers_Birthday, @Customers_Phone_Number, @Customers_Email)";
                command.Parameters.Add("@Customers_Document", SqlDbType.Int).Value = customersModel.Document;
                command.Parameters.Add("@Customers_First_Name", SqlDbType.NVarChar).Value = customersModel.FirstName;
                command.Parameters.Add("@Customers_Last_Name", SqlDbType.NVarChar).Value = customersModel.LastName;
                command.Parameters.Add("@Customers_Address", SqlDbType.NVarChar).Value = customersModel.Address;
                command.Parameters.Add("@Customers_Birthday", SqlDbType.Date).Value = customersModel.Birthday;
                command.Parameters.Add("@Customers_Phone_Number", SqlDbType.NVarChar).Value = customersModel.PhoneNumber;
                command.Parameters.Add("@Customers_Email", SqlDbType.NVarChar).Value = customersModel.Email;
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
                command.CommandText = "DELETE FROM Customers WHERE Customers_Id = @id";
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                command.ExecuteNonQuery();

            }
        }

        public void Edit(CustomersModel customersModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"UPDATE Customers
                                      SET Customers_Document =@Customers_Document,
                                      Customers_First_Name = @Customers_First_Name,
                                      Customers_Last_Name = @Customers_Last_Name,
                                      Customers_Address = @Customers_Address,
                                      Customers_Birthday = @Customers_Birthday,
                                      Customers_Phone_Number = @Customers_Phone_Number,
                                      Customers_Email = @Customers_Email
                                      WHERE Customers_Id = @Customers_Id";
                command.Parameters.Add("@Customers_Document", SqlDbType.Int).Value = customersModel.Document;
                command.Parameters.Add("@Customers_First_Name", SqlDbType.NVarChar).Value = customersModel.FirstName;
                command.Parameters.Add("@Customers_Last_Name", SqlDbType.NVarChar).Value = customersModel.LastName;
                command.Parameters.Add("@Customers_Address", SqlDbType.NVarChar).Value = customersModel.Address;
                command.Parameters.Add("@Customers_Birthday", SqlDbType.Date).Value = customersModel.Birthday;
                command.Parameters.Add("@Customers_Phone_Number", SqlDbType.NVarChar).Value = customersModel.PhoneNumber;
                command.Parameters.Add("@Customers_Email", SqlDbType.NVarChar).Value = customersModel.Email;
                command.Parameters.Add("@Customers_Id", SqlDbType.Int).Value = customersModel.Id;
                command.ExecuteNonQuery();

            }
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
            int customersDocument = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0; ;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"SELECT * FROM Customers
                                       WHERE Customers_Id=@id or Customers_Document LIKE @Customers_Document + '%'
                                       ORDER By Customers_Id DESC";
                command.Parameters.Add("@id", SqlDbType.Int).Value = customersId;
                command.Parameters.Add("@Customers_Document", SqlDbType.Int).Value = customersDocument;
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
