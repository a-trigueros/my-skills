using Acme.Orders.Domain;

namespace Acme.Orders.Application;

public class PlaceOrderHandler(IOrderRepository orders)
{
    public Guid Handle(PlaceOrderCommand command)
    {
        if (command.Lines.Count == 0)
            throw new InvalidOperationException("An order needs at least one line.");

        var order = new Order
        {
            Id = Guid.NewGuid(),
            CustomerName = command.CustomerName,
            Status = OrderStatus.Draft
        };

        var totalUnits = 0;
        foreach (var line in command.Lines)
        {
            if (line.Quantity <= 0)
                throw new InvalidOperationException($"Quantity must be positive for {line.Sku}.");
            order.Lines.Add(new OrderLine
            {
                Sku = line.Sku,
                Quantity = line.Quantity,
                UnitPrice = line.UnitPrice
            });
            totalUnits += line.Quantity;
        }

        // Remise grossiste : 5% à partir de dix unités.
        if (totalUnits >= 10)
            order.DiscountRate = 0.05m;

        order.Status = OrderStatus.Confirmed;
        order.ConfirmedAt = DateTime.Now;

        orders.Save(order);
        return order.Id;
    }
}
