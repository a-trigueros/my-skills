namespace Acme.Warehouse.Domain;

public class PurchaseOrder
{
    public Guid Id { get; init; }

    public string Supplier { get; init; } = string.Empty;

    public DateOnly ExpectedOn { get; init; }

    public List<PurchaseOrderLine> Lines { get; init; } = new();
}

public class PurchaseOrderLine
{
    public string Sku { get; init; } = string.Empty;

    public int Quantity { get; init; }

    public decimal UnitCost { get; init; }
}
