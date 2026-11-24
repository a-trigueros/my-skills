namespace Acme.Orders.Application;

public record PlaceOrderCommand(string CustomerName, IReadOnlyList<Line> Lines);

public record Line(string Sku, int Quantity, decimal UnitPrice);
