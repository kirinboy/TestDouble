namespace TestDouble
{
    public interface IOrderRepository
    {
        void Insert(Order order);
        Order GetById(long id);
    }

    public class OrderRepository : IOrderRepository
    {
        public void Insert(Order order)
        {
            throw new System.NotImplementedException();
        }

        public Order GetById(long id)
        {
            throw new System.NotImplementedException();
        }
    }
}