namespace Shipments.Infrastructure;

public class ShipmentStore
{
    public List<ShipmentRow> Shipments { get; } = new();

    public void Add(ShipmentRow row) => Shipments.Add(row);
}
