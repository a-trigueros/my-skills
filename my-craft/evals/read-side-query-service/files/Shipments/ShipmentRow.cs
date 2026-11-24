namespace Shipments.Infrastructure;

public class ShipmentRow
{
    public Guid Id { get; init; }

    public Guid CustomerId { get; init; }

    public DateOnly RegisteredOn { get; init; }

    public string Status { get; init; } = string.Empty;

    public string Carrier { get; init; } = string.Empty;

    public string TrackingNumber { get; init; } = string.Empty;
}
