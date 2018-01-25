namespace TestDouble
{
    public interface IStockService
    {
        void Pick(Product product, int count);
    }

    public class StockService : IStockService
    {
        public void Pick(Product product, int count)
        {
            throw new System.NotImplementedException();
        }
    }
}