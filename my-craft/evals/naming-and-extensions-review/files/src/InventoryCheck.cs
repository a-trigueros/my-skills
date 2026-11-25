using Acme.Warehouse.Domain;

namespace Acme.Warehouse.Application;

public interface IInventoryChecker
{
    bool IsBelowReorderThreshold(StockItem item);
}

public class InventoryCheckerImpl : IInventoryChecker
{
    public bool IsBelowReorderThreshold(StockItem item) =>
        item.QuantityOnHand <= item.ReorderThreshold;
}
