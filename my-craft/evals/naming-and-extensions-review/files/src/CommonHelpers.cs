using Acme.Warehouse.Domain;

namespace Acme.Warehouse.Helpers;

public static class CommonHelpers
{
    public static bool NeedsReorder(this StockItem item) =>
        item.QuantityOnHand <= item.ReorderThreshold;

    public static int TotalUnits(this PurchaseOrder order) =>
        order.Lines.Sum(line => line.Quantity);
}
