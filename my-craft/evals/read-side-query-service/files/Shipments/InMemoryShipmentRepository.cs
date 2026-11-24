namespace Shipments.Infrastructure;

public class InMemoryShipmentRepository(ShipmentStore store) : IShipmentRepository
{
    public Shipment? Find(Guid id) =>
        store.Shipments.Where(row => row.Id == id).Select(ToAggregate).FirstOrDefault();

    public IReadOnlyList<Shipment> ForCustomer(Guid customerId) =>
        store.Shipments.Where(row => row.CustomerId == customerId)
            .Select(ToAggregate).ToList();

    public void Save(Shipment shipment)
    {
        var row = ToRow(shipment);
        var index = store.Shipments.FindIndex(existing => existing.Id == row.Id);
        if (index < 0)
            store.Add(row);
        else
            store.Shipments[index] = row;
    }

    private static Shipment ToAggregate(ShipmentRow row) =>
        Shipment.Rehydrate(
            row.Id, row.CustomerId, row.RegisteredOn,
            Enum.Parse<ShipmentStatus>(row.Status),
            row.Carrier, row.TrackingNumber);

    private static ShipmentRow ToRow(Shipment shipment) => new()
    {
        Id = shipment.Id,
        CustomerId = shipment.CustomerId,
        RegisteredOn = shipment.RegisteredOn,
        Status = shipment.Status.ToString(),
        Carrier = shipment.Carrier,
        TrackingNumber = shipment.TrackingNumber
    };
}
