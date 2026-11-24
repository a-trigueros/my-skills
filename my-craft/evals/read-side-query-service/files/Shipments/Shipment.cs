namespace Shipments;

public enum ShipmentStatus
{
    Ready,
    Dispatched,
    Delivered
}

public class Shipment
{
    public Guid Id { get; private set; }

    public Guid CustomerId { get; private set; }

    public DateOnly RegisteredOn { get; private set; }

    public ShipmentStatus Status { get; private set; }

    public string Carrier { get; private set; } = string.Empty;

    public string TrackingNumber { get; private set; } = string.Empty;

    private Shipment() { }

    public static Shipment Register(Guid customerId, DateOnly registeredOn) => new()
    {
        Id = Guid.NewGuid(),
        CustomerId = customerId,
        RegisteredOn = registeredOn,
        Status = ShipmentStatus.Ready
    };

    // Reconstitution depuis la persistance.
    internal static Shipment Rehydrate(
        Guid id, Guid customerId, DateOnly registeredOn,
        ShipmentStatus status, string carrier, string trackingNumber) => new()
    {
        Id = id,
        CustomerId = customerId,
        RegisteredOn = registeredOn,
        Status = status,
        Carrier = carrier,
        TrackingNumber = trackingNumber
    };

    public void Dispatch(string carrier)
    {
        if (Status != ShipmentStatus.Ready)
            throw new InvalidOperationException("Only a ready shipment can be dispatched.");
        if (string.IsNullOrWhiteSpace(carrier))
            throw new ArgumentException("A dispatch needs a carrier.", nameof(carrier));
        Status = ShipmentStatus.Dispatched;
        Carrier = carrier;
    }

    public void AssignTracking(string trackingNumber)
    {
        if (Status != ShipmentStatus.Dispatched)
            throw new InvalidOperationException("Tracking is assigned once dispatched.");
        TrackingNumber = trackingNumber;
    }
}
