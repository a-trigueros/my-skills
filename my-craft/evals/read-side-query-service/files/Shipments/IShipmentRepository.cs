namespace Shipments;

public interface IShipmentRepository
{
    Shipment? Find(Guid id);

    IReadOnlyList<Shipment> ForCustomer(Guid customerId);

    void Save(Shipment shipment);
}
