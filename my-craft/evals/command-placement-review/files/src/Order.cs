namespace Acme.Orders.Domain;

public enum OrderStatus
{
    Draft,
    Confirmed,
    Shipped
}

public class Order
{
    public Guid Id { get; set; }

    public string CustomerName { get; set; } = string.Empty;

    public OrderStatus Status { get; set; }

    public DateTime? ConfirmedAt { get; set; }

    public decimal DiscountRate { get; set; }

    public List<OrderLine> Lines { get; set; } = new();
}

public class OrderLine
{
    public string Sku { get; set; } = string.Empty;

    public int Quantity { get; set; }

    public decimal UnitPrice { get; set; }
}
