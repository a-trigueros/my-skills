using Acme.Warehouse.Domain;

namespace Acme.Warehouse.Application;

public interface IPriceOrders
{
    decimal TotalCost(PurchaseOrder order);
}

public class OrderPricerImpl : IPriceOrders
{
    public decimal TotalCost(PurchaseOrder order) =>
        order.Lines.Sum(line => line.Quantity * line.UnitCost);
}
