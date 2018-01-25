namespace TestDouble
{
    class StubCustomerService : ICustomerService
    {
        public Customer GetById(long customerId)
        {
            return new Customer { Id = customerId };
        }
    }
}