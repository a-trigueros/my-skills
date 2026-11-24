namespace Shipments;

public class CustomerShipmentHistoryReader(IShipmentRepository shipments)
{
    public List<ShipmentApiModel> History(Guid customerId)
    {
        var result = new List<ShipmentApiModel>();
        foreach (var shipment in shipments.ForCustomer(customerId))
        {
            result.Add(new ShipmentApiModel
            {
                Id = shipment.Id,
                CustomerId = shipment.CustomerId,
                RegisteredOn = shipment.RegisteredOn,
                Status = shipment.Status.ToString(),
                Carrier = shipment.Carrier,
                TrackingNumber = shipment.TrackingNumber
            });
        }
        return result;
    }
}
