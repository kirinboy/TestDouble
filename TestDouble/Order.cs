namespace TestDouble
{
    public class Order : Entity
    {
        public Product Product { get; }
        public Customer Customer { get; }
        public int Count { get; }

        public Order(Product product, Customer customer, int count)
        {
            Product = product;
            Customer = customer;
            Count = count;
        }
    }
}