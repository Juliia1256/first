namespace ConsoleApp1
{

    public class Product
    {
        public Product(int id, string name, decimal price)
        {
            Id = id;
            Name = name;
            Price = price;
        }

        public int Id { get; }
        public string Name { get; }
        public decimal Price { get; }

        public override string ToString() =>
            $"\"{Name}\"(Id:{Id}) with price {Price}";
    }


}
