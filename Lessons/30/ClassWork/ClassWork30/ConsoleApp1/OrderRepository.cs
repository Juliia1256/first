using System;
using System.Collections;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Data.SqlClient;

namespace ConsoleApp1
{
    public class OrderRepository
    {
        private readonly string _connectionString;

        public OrderRepository(string connectionDtring)
        {
            _connectionString = connectionDtring;
        }
        public int Create(
            int customerId,
            float discount,
            Dictionary<int, int> lines)
        {
            using var connection = CreateConnection();
            using var transaction = connection.BeginTransaction();

            try
            {
                using var orderCommand = connection.CreateCommand();
                orderCommand.Transaction = transaction;   //простановка транзакции
                orderCommand.CommandText = "sp_OrdersCreate";
                orderCommand.CommandType = CommandType.StoredProcedure;
                orderCommand.Parameters.AddWithValue("customerId", customerId);
                orderCommand.Parameters.AddWithValue("discount", discount);
                var id = orderCommand.Parameters.Add("id", SqlDbType.Int);
                id.Direction = ParameterDirection.Output;
                orderCommand.ExecuteNonQuery();
                var orderId = (int)id.Value;
                foreach (var (productId, count) in lines)  //синтаксис деконструкции
                {
                    using var lineCommand = connection.CreateCommand();
                    lineCommand.Transaction = transaction;
                    lineCommand.CommandText =
                      @"INSERT INTO [OrderLine]([OrderId], [ProductId], [Count]) 
					  VALUES (@orderId, @productId, @count)";
                    lineCommand.CommandType = CommandType.Text;
                    lineCommand.Parameters.AddWithValue("orderId", orderId);
                    lineCommand.Parameters.AddWithValue("productId", productId);
                    lineCommand.Parameters.AddWithValue("count", count);
                    lineCommand.ExecuteNonQuery();
                }
                transaction.Commit();
                return orderId;
            }
            catch (SqlException)
            {
                transaction.Rollback();
                throw;
            }
        }
        private SqlConnection CreateConnection()
        {
            var connection = new SqlConnection(_connectionString);
            connection.Open();
            return connection;
        }
        public int GetCount()
        {
            using var connection = CreateConnection();
            using var command = connection.CreateCommand();
            command.CommandText = "Select count(*) from [Order]";
            command.CommandType = CommandType.Text;
            return (int)command.ExecuteScalar();
        }
        public Order GetById(int id)
        {
            using var connection = CreateConnection();
            using var command = connection.CreateCommand();
            command.CommandText = "sp_Get_Order_With_TotalSumm_By_Id";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("id", id);
            using var reader = command.ExecuteReader();
            var result = Read(reader).FirstOrDefault();

            if (result == null)
            {
                throw new ArgumentException($"The order with id {id} not found");
            }
            return result;
        }
        public List<Order> GetAll()
        {
            using var connection = CreateConnection();
            using var command = connection.CreateCommand();
            command.CommandText = "sp_Get_Order_With_TotalSumm";
            command.CommandType = CommandType.StoredProcedure;

            using var reader = command.ExecuteReader();
            return Read(reader).ToList();
        }
        private IEnumerable<Order> Read(SqlDataReader reader)
        {
            if (!reader.HasRows)
            {
                yield break;
            }
            var idIndex = reader.GetOrdinal("Id");
            var CustomerIdIndex = reader.GetOrdinal("CustomerId");
            var OrderDateIndex = reader.GetOrdinal("OrderDate");
            var DiscountIndex = reader.GetOrdinal("Discount");
            var TotalOrderSummIndex = reader.GetOrdinal("TotalOrderSumm");
            while (reader.Read())
            {
                yield return new Order(
                    reader.GetInt32(idIndex),
                    reader.GetInt32(CustomerIdIndex),
                    reader.GetDateTimeOffset(OrderDateIndex),
                    (float)reader.GetDouble(DiscountIndex),
                    (decimal)reader.GetDouble(TotalOrderSummIndex));
            }
        }
    }
}
