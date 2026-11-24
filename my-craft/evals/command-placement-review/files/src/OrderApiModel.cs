namespace Acme.Orders.Api;

public class OrderApiModel
{
    public Guid Id { get; set; }

    public string CustomerName { get; set; } = string.Empty;

    public string Status { get; set; } = string.Empty;

    public int LineCount { get; set; }
}
