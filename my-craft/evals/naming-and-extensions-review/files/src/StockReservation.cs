using Acme.Warehouse.Domain;

namespace Acme.Warehouse.Application;

public interface IReserveStock
{
    bool CanReserve(StockItem item, int quantity);
}

public class StockReserver : IReserveStock
{
    public bool CanReserve(StockItem item, int quantity) =>
        quantity > 0 && quantity <= item.QuantityOnHand;
}
