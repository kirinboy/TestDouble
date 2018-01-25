namespace TestDouble
{
    public interface ICustomerService
    {
        Customer GetById(long customerId);
    }

    public class CustomerService : ICustomerService
    {
        public Customer GetById(long customerId)
        {
            throw new System.NotImplementedException();
        }
    }
}