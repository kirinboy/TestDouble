namespace TestDouble
{
    class StubProductService : IProductService
    {
        public Product GetById(long productId)
        {
            return new Product { Id = productId };
        }
    }
}