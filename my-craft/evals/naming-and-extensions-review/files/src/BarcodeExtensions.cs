namespace Acme.Warehouse.Domain;

public static class BarcodeExtensions
{
    public static string Normalized(this Barcode barcode) =>
        barcode.Value.Trim().ToUpperInvariant();
}
