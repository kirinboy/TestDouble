using System.Collections.Generic;

namespace TestDouble
{
    class FakeOrderRepository : IOrderRepository
    {
        readonly IDictionary<long, Order> orders = new Dictionary<long, Order>();
        long id = 1;

        public void Insert(Order order)
        {
            order.Id = id;
            orders.Add(id, order);
            id++;
        }

        public Order GetById(long id)
        {
            return orders[id];
        }
    }

    class StubOrderRepository : IOrderRepository
    {
        public void Insert(Order order)
        {

        }

        public Order GetById(long id)
        {
            throw new System.NotImplementedException();
        }
    }
}