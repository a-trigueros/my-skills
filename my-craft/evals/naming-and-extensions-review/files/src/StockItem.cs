namespace Acme.Warehouse.Domain;

public class StockItem
{
    public Guid Id { get; init; }

    public string Sku { get; init; } = string.Empty;

    public string Label { get; init; } = string.Empty;

    public int QuantityOnHand { get; set; }

    public int ReorderThreshold { get; init; }
}
