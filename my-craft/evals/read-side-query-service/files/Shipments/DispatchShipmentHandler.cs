namespace Shipments;

public class DispatchShipmentHandler(IShipmentRepository shipments)
{
    public void Handle(Guid shipmentId, string carrier)
    {
        var shipment = shipments.Find(shipmentId)
            ?? throw new InvalidOperationException($"Unknown shipment {shipmentId}.");
        shipment.Dispatch(carrier);
        shipments.Save(shipment);
    }
}
