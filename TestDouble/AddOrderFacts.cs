using Xunit;

namespace TestDouble
{
    public class AddOrderFacts
    {
        /// <summary>
        /// fake object and test stub
        /// </summary>
        [Fact]
        public void should_add_an_order()
        {
            // setup
            var fakeOrderRepository = new FakeOrderRepository();
            var stubCustomerService = new StubCustomerService();
            var stubProductService = new StubProductService();
            var mockStockService = new StubStockService();

            // exercise
            var sut = new OrderService(fakeOrderRepository, stubProductService, stubCustomerService, mockStockService);
            sut.AddOrder(1, 2, 3);

            // verify
            var order = fakeOrderRepository.GetById(1);
            Assert.Equal(1, order.Id);
            Assert.Equal(1, order.Product.Id);
            Assert.Equal(2, order.Customer.Id);
            Assert.Equal(3, order.Count);

            // teardown
        }

        /// <summary>
        /// test stub, test spy and dummy object
        /// </summary>
        [Fact]
        public void should_decrease_stock_when_add_order()
        {
            // setup
            var stubOrderRepository = new StubOrderRepository();
            var stubCustomerService = new StubCustomerService();
            var stubProductService = new StubProductService();
            var mockStockService = new SpyStockService(hasPickCalled: false);

            // exercise
            var sut = new OrderService(stubOrderRepository, stubProductService, stubCustomerService, mockStockService);
            sut.AddOrder(DummyObjects.Long, DummyObjects.Long, DummyObjects.Int);

            // verify
            Assert.True(mockStockService.HasPickCalled);

            // teardown
        }

        /// <summary>
        /// test stub and mock object
        /// </summary>
        [Fact]
        public void should_decrease_correct_when_add_order()
        {
            // setup
            var stubOrderRepository = new StubOrderRepository();
            var stubCustomerService = new StubCustomerService();
            var stubProductService = new StubProductService();
            var mockStockService = new MockStockService(hasPickCalled: false);

            // exercise
            var sut = new OrderService(stubOrderRepository, stubProductService, stubCustomerService, mockStockService);
            sut.AddOrder(1, 2, 3);

            // verify
            Assert.True(mockStockService.HasPickCalled);

            // teardown
        }
    }
}