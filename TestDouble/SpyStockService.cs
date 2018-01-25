namespace TestDouble
{
    class SpyStockService : IStockService
    {
        public SpyStockService(bool hasPickCalled)
        {
            HasPickCalled = hasPickCalled;
        }

        public bool HasPickCalled { get; set; }

        public void Pick(Product product, int count)
        {
            HasPickCalled = true;
        }
    }
}