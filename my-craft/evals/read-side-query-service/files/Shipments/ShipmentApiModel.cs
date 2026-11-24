namespace Shipments;

public class ShipmentApiModel
{
    public Guid Id { get; set; }

    public Guid CustomerId { get; set; }

    public DateOnly RegisteredOn { get; set; }

    public string Status { get; set; } = string.Empty;

    public string Carrier { get; set; } = string.Empty;

    public string TrackingNumber { get; set; } = string.Empty;
}
