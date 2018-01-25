namespace TestDouble
{
    public class OrderService
    {
        readonly IProductService productService;
        readonly ICustomerService customerService;
        readonly IOrderRepository orderRepository;
        readonly IStockService stockService;

        public OrderService(IOrderRepository orderRepository, IProductService productService, ICustomerService customerService, IStockService stockService)
        {
            this.productService = productService;
            this.customerService = customerService;
            this.orderRepository = orderRepository;
            this.stockService = stockService;
        }

        public void AddOrder(long productId, long customerId, int count)
        {
            var product = productService.GetById(productId);
            var customer = customerService.GetById(customerId);
            var order = new Order(product, customer, count);
            stockService.Pick(product, count);
            orderRepository.Insert(order);
        }
    }
}