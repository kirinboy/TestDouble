using Xunit;

namespace TestDouble
{
    class MockStockService : IStockService
    {
        public MockStockService(bool hasPickCalled)
        {
            HasPickCalled = hasPickCalled;
        }

        public bool HasPickCalled { get; set; }

        public void Pick(Product product, int count)
        {
            HasPickCalled = true;
            Assert.Equal(1, product.Id);
        }
    }
}