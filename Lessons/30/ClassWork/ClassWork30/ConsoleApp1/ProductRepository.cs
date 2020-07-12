using System;
using System.Collections;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Data.SqlClient;

namespace ConsoleApp1
{

    public class ProductRepository
    {
        private readonly string _connectionString;

        public ProductRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public int GetCount()
        {

            using var connection = CreateConnection();
            using var command = connection.CreateCommand();
            command.CommandText = "Select count(*) from [Product]";
            command.CommandType = CommandType.Text;
            return (int)command.ExecuteScalar();
        }

        public Product GetById(int id)
        {
            using var connection = CreateConnection();
            using var command = connection.CreateCommand();
            //command.CommandText = $"Select count(*) from [Product] where Id = {id}";
            command.CommandText = "Select * from [Product] where Id = @id";
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("id", id);

            using var reader = command.ExecuteReader();
            var result = Read(reader).FirstOrDefault();

            if (result == null)
            {
                throw new ArgumentException($"The product with id {id} not found");
            }
            return result;
        }
        public List<Product> GetAll()
        {
            using var connection = CreateConnection();
            using var command = connection.CreateCommand();
            command.CommandText = "Select * from [Product]";
            command.CommandType = CommandType.Text;

            using var reader = command.ExecuteReader();
            return Read(reader).ToList();
        }
        private SqlConnection CreateConnection()
        {
            var connection = new SqlConnection(_connectionString);
            Console.WriteLine("Connection openning");
            connection.Open();
            return connection;
        }
        public int Create(string name, decimal price)
        {
            using var connection = CreateConnection();
            using var command = connection.CreateCommand();
            command.CommandText = "sp_ProductsCreate";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("name", name);
            command.Parameters.AddWithValue("price", price);
            var id = command.Parameters.Add("id", SqlDbType.Int);
            id.Direction = ParameterDirection.Output;
            command.ExecuteNonQuery();
            return (int)id.Value;
        }

        private IEnumerable<Product> Read(SqlDataReader reader)
        {
            if (!reader.HasRows)
            {
                yield break;
            }
            var idIndex = reader.GetOrdinal("Id");
            var nameIndex = reader.GetOrdinal("Name");
            var priceIndex = reader.GetOrdinal("Price");
            while (reader.Read())
            {
                yield return new Product(
                    reader.GetInt32(idIndex),
                    reader.GetString(nameIndex),
                    reader.GetDecimal(priceIndex));
            }
        }
    }

}
