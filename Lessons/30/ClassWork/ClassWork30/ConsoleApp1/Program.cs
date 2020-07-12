using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
   internal class Program
    {
        private const string ConnectionString =
            "Server=tcp:shadow-art.database.windows.net,1433;" +
            "Initial Catalog=reminder;" +
            "Persist Security Info=False;" +
            "User ID=u_sheykina@shadow-art;" +
            "Password=ccf14IFn1NHnJIac6L38;" +
            "Encrypt=True";


        private static void Main(string[] args)
        {

            //var productRepository = new ProductRepository(ConnectionString);
            //var productsCount = productRepository.GetCount();
            //Console.WriteLine($"Count of rows in table orders: {productsCount}");

            //var product = productRepository.GetById(9);
            //Console.WriteLine(product);

            //Console.WriteLine("Create product with name:");
            //var productName = Console.ReadLine();
            //Console.WriteLine("Product price:");
            //var productPrice = decimal.Parse(Console.ReadLine());
            //productRepository.Create(productName, productPrice);

            //var products = productRepository.GetAll();
            //foreach (var item in products)
            //{
            //    Console.WriteLine(item);
            //}

            var orderRepository = new OrderRepository(ConnectionString);
            var orderId = orderRepository.Create(
                5,
                0.0f,
                new Dictionary<int, int>
                {
                    [10] = 5,
                    [11] = 3
                }
            );
            Console.WriteLine($"Created order id {orderId}");
            var orderCount = orderRepository.GetCount();
            Console.WriteLine($"Get result Order Count:  {orderCount}");
            var orderbyId = orderRepository.GetById(20);
            Console.WriteLine($"Get result: {orderbyId }");
            var orderAll = orderRepository.GetAll();
            foreach (var item in orderAll)
            {
                Console.WriteLine($"Get result:{item}");
            }
            Console.ReadKey();


        }

    }
}
