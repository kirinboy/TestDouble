namespace TestDouble
{
    public interface IProductService
    {
        Product GetById(long productId);
    }

    public class ProductService : IProductService
    {
        public Product GetById(long productId)
        {
            throw new System.NotImplementedException();
        }
    }
}