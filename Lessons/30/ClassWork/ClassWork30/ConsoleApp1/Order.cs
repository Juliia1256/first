using System;

namespace ConsoleApp1
{
    public class Order
    {
        public Order(int id, int customerId, DateTimeOffset orderDate, float discount, decimal totalOrderSumm)
        {
            Id = id;
            CustomerId = customerId;
            OrderDate = orderDate;
            Discount = discount;
            TotalOrderSumm = totalOrderSumm;
        }

        public int Id { get; }
        public int CustomerId { get; }
        public DateTimeOffset OrderDate { get; }
        public float Discount { get; }
        public decimal TotalOrderSumm { get; }
        public override string ToString() =>
    $"\"Order number {Id}\" from {OrderDate} with discount {Discount*100}%, total order summ is {TotalOrderSumm}";

    }
}
